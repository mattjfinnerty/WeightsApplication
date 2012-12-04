using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightsV1
{
    public partial class TemplateEditor : Form
    {
        public TemplateEditor()
        {
            InitializeComponent();
            PopulateExcerciseTypeCombo();
        }

        private void PopulateExcerciseTypeCombo()
        {
            DataSet excerciseTypes = GetExcerciseTypes();
            comboBoxType.DataSource = excerciseTypes.Tables[0];
            comboBoxType.DisplayMember = "ExcerciseTypeDesc";
        }

        private void buttonAddExcercise_Click(object sender, EventArgs e)
        {
            ComboBox newComboBox = new ComboBox();
            DataSet excerciseNames = GetExcerciseNames();
            newComboBox.DataSource = excerciseNames.Tables[0];
            newComboBox.DisplayMember = "ExcerciseName";
            newComboBox.Location = buttonAddExcercise.Location;
            buttonAddExcercise.Top += 30;
            Controls.Add(newComboBox);
            if(checkBoxRestrict.Checked)
                Controls.Add(createLabel(newComboBox));
        }

        private Label createLabel(ComboBox comboBox)
        {
            string labelText = "Restricted To: " + comboBoxType.Text;
            Label newLabel = new Label {Text = labelText, Location = comboBox.Location};
            newLabel.Left += 125;
            newLabel.Top += 2;
            newLabel.ForeColor = Color.DarkRed;
            return newLabel;
        }

        private DataSet GetExcerciseNames()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                DataSet ds = new DataSet();
                string sqlQuery = CreateSQLQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
                adapter.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private static DataSet GetExcerciseTypes()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("Select ExcerciseTypeDesc from ExcerciseType", conn);
                adapter.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private string CreateSQLQuery()
        {
            if (!checkBoxRestrict.Checked)
                return "Select ExcerciseName from Excercise";
            else
            {
                int? exTypeId = GetExcerciseTypeId();
                return "Select ExcerciseName from Excercise where ExcerciseTypeId =" + exTypeId;    
            }


        }

        private int? GetExcerciseTypeId()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ExcerciseTypeID from ExcerciseType where ExcerciseTypeDesc = '" + comboBoxType.Text + "'", conn);
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {   MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
