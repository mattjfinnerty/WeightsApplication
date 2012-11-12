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
    public partial class AthleteAdd : Form
    {
        public AthleteAdd()
        {
            InitializeComponent();
        }

        private void buttonAthlete_Click(object sender, EventArgs e)
        {
            //Get the values to fire off first

            string forename = textBoxForename.Text.ToString();
            string surname = textBoxSurname.Text.ToString();
            double weight;
            Int32 AthleteID;
            labelForename.ForeColor = Color.Black;
            labelSurname.ForeColor = Color.Black;

            //Check the weight here as it must parse to pass to the SP

            if (!double.TryParse(textBoxWeight.Text, out weight)&&!string.IsNullOrEmpty(textBoxWeight.Text.ToString()))
            {
                MessageBox.Show("The value in the weight field is not valid, please review this data");
                labelWeight.ForeColor = Color.Red;
            }
            else { labelWeight.ForeColor = Color.Black; }

            //Now determine which text fields have data and pass to the SP Method

            if (!string.IsNullOrEmpty(forename) && !string.IsNullOrEmpty(surname) && weight != 0.0)
            {
                AthleteID = AddAthleteSP(forename, surname, weight);
                labelForename.ForeColor = Color.White;
                labelSurname.ForeColor = Color.White;
                TestSPSuccess(AthleteID);
            }
            else if (!string.IsNullOrEmpty(forename) && !string.IsNullOrEmpty(surname))
            {
                AthleteID = AddAthleteSP(forename, surname);
                TestSPSuccess(AthleteID);
            }
            else
            {
                if (string.IsNullOrEmpty(forename))
                { labelForename.ForeColor = Color.Red; }
                if (string.IsNullOrEmpty(surname))
                { labelSurname.ForeColor = Color.Red; }
                MessageBox.Show("Please ensure you complete the relevant fields marked in Red.");
            }
        }

        private Int32 AddAthleteSP(string firstname, string secondname)
        {
            try
            {
                Int32 AthleteID = 0;
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddAthlete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Forename", firstname);
                cmd.Parameters.AddWithValue("@Surname",secondname);
                SqlParameter AthID = new SqlParameter("@AthleteID",AthleteID);
                AthID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(AthID);
                cmd.ExecuteNonQuery();
                conn.Close();
                AthleteID = Convert.ToInt32(AthID.Value);
                return AthleteID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        private Int32 AddAthleteSP(string firstname, string secondname, double weight)
        {
            try
            {
                Int32 AthleteID = 0;
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddAthlete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Forename", firstname);
                cmd.Parameters.AddWithValue("@Surname", secondname);
                cmd.Parameters.AddWithValue("@WeightKG", weight);
                SqlParameter AthID = new SqlParameter("@AthleteID", AthleteID);
                AthID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(AthID);
                cmd.ExecuteNonQuery();
                conn.Close();
                AthleteID = Convert.ToInt32(AthID.Value);
                return AthleteID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        private void TestSPSuccess(Int32 AthleteID)
        {
         if(AthleteID == 0)
                {MessageBox.Show("Application failed to add the new Athlete.");}
                else
                {MessageBox.Show("Athlete added successfully! \nNew Athlete created with an ID of " + AthleteID.ToString());}
        }
    }
}
