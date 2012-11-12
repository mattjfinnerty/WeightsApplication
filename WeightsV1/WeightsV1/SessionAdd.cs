using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.IO;

namespace WeightsV1
{
    public partial class SessionAdd : Form
    {
        public SessionAdd()
        {
            InitializeComponent();
        }

        private void SessionAdd_Load(object sender, EventArgs e)
        {
            FillListBox();
            GetSessionTemplates();
            dataGridView1.AllowUserToAddRows = false;
            comboBoxSessions_SelectedIndexChanged(sender, e);
            FillRepsBox();
        }

        //Method for populating the list box with Athletes forename and surname

        private void FillListBox()
        {

            SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;DataBase=Weights;Integrated Security=SSPI;Connection Timeout = 5");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select Forename + ' ' + Surname AS 'Name' from Athlete", conn);
            adapter.Fill(ds);
            listBoxAthletes.DataSource = ds.Tables[0];
            listBoxAthletes.DisplayMember = "Name";
        }

        // Method for populating Datagridview

        private void CreateExcerciseRow(XmlNode node)
        {
            DataGridViewColumn colOne = new DataGridViewColumn();
            colOne.ReadOnly = true;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            colOne.CellTemplate = cell;
            foreach (XmlNode xNode in node)
            {
                if (xNode.Name.ToString() == "SessionName")
                {
                    colOne.HeaderText = xNode.InnerText;
                    dataGridView1.Columns.Add(colOne);
                }
                else if (xNode.Name.ToString() == "ExcerciseID")
                {
                    //Now Return the Names of the excercises from the db!

                    Int32 exIDString = Convert.ToInt32(xNode.InnerText);
                    SqlParameter exIDparam = new SqlParameter("@ExcerciseID", SqlDbType.VarChar, 100);
                    exIDparam.Value = exIDString;
                    SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;DataBase=Weights;Integrated Security=SSPI;Connection Timeout = 5");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select ExcerciseName from Excercise where ExcerciseID = @ExcerciseID", conn);

                    //Read the data!

                    SqlDataReader rdr = null;
                    cmd.Parameters.Add(exIDparam);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        string[] row = new string[] { rdr.GetValue(0).ToString() };   //Add them to the column created.
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        //Method to populate the combobox with the templates

        private void GetSessionTemplates()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\SessionTemplates");
            FileInfo[] files = di.GetFiles("*.xml", SearchOption.AllDirectories);
            foreach (FileInfo f in files)
            {
                comboBoxSessions.Items.Add(f);
            }
        }

        //When a new item is chosen in the template box - repopulate the datagridview

        private void comboBoxSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            string template = comboBoxSessions.GetItemText(this.comboBoxSessions.SelectedItem);
            if (template == "")
            {
                DirectoryInfo di = new DirectoryInfo(@"D:\SessionTemplates\");
                FileInfo difiles = di.GetFiles()[0];
                template = difiles.ToString();
             }
            XmlDocument doc = new XmlDocument();
            template = @"D:\SessionTemplates\" + template;
            doc.Load(template);
            CreateExcerciseRow(doc.DocumentElement as XmlNode);
        }

        private void buttonAddAthlete_Click(object sender, EventArgs e)
        {
            //Add the selected Athlete to the DataGridView

            string selectedAthlete = ((DataRowView)listBoxAthletes.SelectedItem)[listBoxAthletes.DisplayMember].ToString();
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            col.CellTemplate = cell;
            col.HeaderText = selectedAthlete;
            dataGridView1.Columns.Add(col);
        }

        //Method to Send the completed data grid to db

        private void SendData()
        {
            Int32 recordSessionId = AddRecordSession();
            string excerciseName = "";
            string athlete = "";
            if (recordSessionId != 0) //Test for successful addition of record session.
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != 0)
                        {
                            excerciseName = row.Cells[0].Value.ToString();                              //Assign excercise name to variable
                            athlete = dataGridView1.Columns[cell.ColumnIndex].HeaderText.ToString();    //Assign Athlete name to variable
                            SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                            conn.Open();

                            //Get AthleteID

                            SqlCommand cmdAthleteID = new SqlCommand("GetAthleteID", conn);
                            cmdAthleteID.CommandType = CommandType.StoredProcedure;
                            cmdAthleteID.Parameters.AddWithValue("@AthleteFullName", athlete);
                            SqlParameter athId = new SqlParameter("@AthleteID", 0);
                            athId.Direction = ParameterDirection.Output;
                            cmdAthleteID.Parameters.Add(athId);
                            cmdAthleteID.ExecuteNonQuery();

                            int athleteID = Convert.ToInt32(athId.Value);
                            if(athleteID == 0)
                            {
                                MessageBox.Show("Excercise record for " + athlete + " has not been added successfully.");
                                break;
                            }

                            //Get ExcerciseID

                            SqlCommand cmdExcerciseID = new SqlCommand("Select ExcerciseID from Excercise where ExcerciseName = '" + excerciseName + "'", conn);
                            int exerciseID = (int)cmdExcerciseID.ExecuteScalar();

                            //Already have RecordSessionId - now assign RecordDate, Weight & Reps

                            DateTime recordDate = dateTimePicker1.Value;
                            int reps = Convert.ToInt32(comboBoxReps.GetItemText(this.comboBoxReps.SelectedItem));
                            double weight = Convert.ToDouble(cell.Value.ToString());

                            //Now add all this crap via the SP!!!!

                            SqlCommand cmdRecordAdd = new SqlCommand("AddRecord", conn);
                            cmdRecordAdd.CommandType = CommandType.StoredProcedure;
                            cmdRecordAdd.Parameters.AddWithValue("@AthleteID", athleteID);
                            cmdRecordAdd.Parameters.AddWithValue("@ExcerciseID", exerciseID);
                            cmdRecordAdd.Parameters.AddWithValue("@RecordSessionID", recordSessionId);
                            cmdRecordAdd.Parameters.AddWithValue("@RecordDate", recordDate);
                            cmdRecordAdd.Parameters.AddWithValue("@Weight", weight);
                            cmdRecordAdd.Parameters.AddWithValue("@Reps", reps);
                            cmdRecordAdd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Data added successfully to the database!");
            }
            else //RecordSession addition has failed if it is zero
            {
                MessageBox.Show("Record Session not created successfully, please try again.");
            }
        }

        private Int32 AddRecordSession()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddRecordSession", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecordSessionDate", dateTimePicker1.Value);
                SqlParameter recSesID = new SqlParameter("@RecordSessionId", 0);
                recSesID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(recSesID);
                cmd.ExecuteNonQuery();
                conn.Close();
                Int32 RecordSessionId = Convert.ToInt32(recSesID.Value);
                return RecordSessionId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        private void FillRepsBox()
        {
            int[] reps = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in reps)
            {
                comboBoxReps.Items.Add(i);
                comboBoxReps.SelectedItem = 1;
            }
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
