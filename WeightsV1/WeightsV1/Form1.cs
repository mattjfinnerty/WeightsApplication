using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZedGraph;

namespace WeightsV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillExcerciseBox();
            Graph homePageGraph = new Graph();
        }

        private void buttonAddAthlete_Click(object sender, EventArgs e)
        {
            Form athleteForm = new AthleteAdd();
            athleteForm.Show();
        }

        private void buttonAddExcerciseType_Click(object sender, EventArgs e)
        {
            Form excerciseTypeForm = new ExcerciseTypeAdd();
            excerciseTypeForm.Show();
        }

        private void button1AddExcercise_Click(object sender, EventArgs e)
        {
            Form excerciseForm = new ExcerciseAdd();
            excerciseForm.Show();
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            Form sessionForm = new SessionAdd();
            sessionForm.Show();
        }

        private void FillExcerciseBox()
        {
            SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ExcerciseName from Excercise",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBoxExcercise.Items.Add(rdr[0]);
            }
            rdr.Close();
            conn.Close();
            comboBoxExcercise.SelectedIndex = 0;
            comboBoxExcercise.SelectedValue = 0;
        }

        private void comboBoxExcercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            string excerciseNewlySelected = (Convert.ToString(comboBoxExcercise.GetItemText(this.comboBoxExcercise.SelectedItem)));
            Graph.CreateHomePageGraph(zedGraphControl1, excerciseNewlySelected);
        }

        private void buttonTemplateManager_Click(object sender, EventArgs e)
        {
            Form templateForm = new TemplateManager();
            templateForm.Show();
        }
    }
}
