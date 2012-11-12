using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeightsV1
{
    public partial class ExcerciseAdd : Form
    {
        public ExcerciseAdd()
        {
            InitializeComponent();

            //Open Connection and populate the Combo Box

            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("Select ExcerciseTypeDesc from ExcerciseType", conn);
                adapter.Fill(ds);
                comboBoxType.DataSource = ds.Tables[0];
                comboBoxType.DisplayMember = "ExcerciseTypeDesc";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonAddExcercise_Click(object sender, EventArgs e)
        {
            //Retrieve the Name and assign to a variable

            string excerciseName = textBoxName.Text.ToString();
            labelExcerciseName.ForeColor = Color.Black;

            //Combobox already ensures a selection is made - retrieve ExcerciseTypeID

            Int32 ExTypeID = 0;

            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ExcerciseTypeID from ExcerciseType where ExcerciseTypeDesc = '" + comboBoxType.Text.ToString() + "'", conn);
                ExTypeID = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }

            //Finally add the data to the db and test for addition

            if(string.IsNullOrEmpty(excerciseName))
            {
                MessageBox.Show("Please complete the Excercise Name field.");
                labelExcerciseName.ForeColor = Color.Red;
            }
            else
            {
                Int32 excerciseID = AddExcercise(excerciseName,ExTypeID);
                TestSuccess(excerciseID);
            }
        }

        private Int32 AddExcercise(string excerciseName, Int32 ID)
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddExcercise", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExcerciseName", excerciseName);
                cmd.Parameters.AddWithValue("@ExcerciseTypeID", ID);
                SqlParameter exID = new SqlParameter("@ExcerciseID", 0);
                exID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(exID);
                cmd.ExecuteNonQuery();
                conn.Close();
                Int32 ExcerID = Convert.ToInt32(exID.Value);
                return ExcerID;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); return 0; }
        }

        private void TestSuccess(Int32 ID)
        {
            if (ID != 0)
            {
                MessageBox.Show("Success! New Excercise added with an ID of " + ID.ToString());
            }
            else
            {
                MessageBox.Show("Update to database failed.");
            }
        }
    }
}
