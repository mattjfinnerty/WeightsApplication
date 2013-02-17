using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeightsV1.ObjectCreation;

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
            labelForename.ForeColor = Color.Black;
            labelSurname.ForeColor = Color.Black;

            //Check the weight here as it must parse to pass to the SP

            if (!double.TryParse(textBoxWeight.Text, out weight)&&!string.IsNullOrEmpty(textBoxWeight.Text))
            {
                labelWeight.ForeColor = Color.Red;
            }
            else 
                labelWeight.ForeColor = Color.Black;

            //Now determine which text fields have data and pass to the SP Method

            if(string.IsNullOrEmpty(forename)||string.IsNullOrEmpty(surname)||labelWeight.ForeColor == Color.Red)
            {
                if (string.IsNullOrEmpty(forename))
                    labelForename.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(surname))
                    labelSurname.ForeColor = Color.Red;
                string messageToShow =
                    labelWeight.ForeColor == Color.Red &&
                    (labelForename.ForeColor == Color.Red || labelSurname.ForeColor == Color.Red)
                        ? "Please ensure the Weight field is valid and fields marked in red are completed."
                        : (labelWeight.ForeColor == Color.Red
                               ? "Please ensure the Weights field contains a valid Weight or is empty."
                               : "Please ensure you complete the relevant fields marked in Red.");
                MessageBox.Show(messageToShow);
            }
            else
            {
                Athlete newAthlete = new Athlete(forename,surname,weight);
                string successMessage = newAthlete.AthleteId == 0
                                            ? "Application failed to add new Athlete."
                                            : "Athlete added successfully!\n\n" + newAthlete.ToString();
                MessageBox.Show(successMessage, "Athlete Addition Status.");
            }
        }
    }
}
