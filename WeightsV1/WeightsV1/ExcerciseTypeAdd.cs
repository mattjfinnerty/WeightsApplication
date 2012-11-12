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
    public partial class ExcerciseTypeAdd : Form
    {
        public ExcerciseTypeAdd()
        {
            InitializeComponent();
        }

        private void buttonAddExcerciseType_Click(object sender, EventArgs e)
        {
            //Retrieve the value and assign
            string excerciseType = textBoxExcerciseType.Text.ToString();
            labelDescription.ForeColor = Color.Black;


            //Test the field to ensure some data is held in it

            if (string.IsNullOrEmpty(excerciseType))
            {
                labelDescription.ForeColor = Color.Red;
                MessageBox.Show("Please ensure you complete the description field.");
            }
            else
            {
                Int32 ExcerciseTypeID = AddExcerciseType(excerciseType);
                TestSPSuccess(ExcerciseTypeID);
            }
        }

        private Int32 AddExcerciseType(string excerciseType)
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddExcerciseType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExcerciseDesc", excerciseType);
                SqlParameter typeID = new SqlParameter("@ExcerciseTypeID", 0);
                typeID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(typeID);
                cmd.ExecuteNonQuery();
                conn.Close();
                Int32 excerciseTypeID = Convert.ToInt32(typeID.Value);
                return excerciseTypeID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;

            }
        }

        private void TestSPSuccess(Int32 ID)
        {
            if (ID != 0)
            {
                MessageBox.Show("Success! Excercise Type added with an ID of " + ID.ToString());
            }
            else
            {
                MessageBox.Show("Update to database failed.");
            }
        }

        private void textBoxExcerciseType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                buttonAddExcerciseType_Click(sender, e);
            }
        }
    }
}
