using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WeightsV1
{
    public partial class TemplateManager : Form
    {
        private const string fileDirectory = @"D:\SessionTemplates\";

        public TemplateManager()
        {
            InitializeComponent();
            FillTemplateListBox();
        }

        private void FillTemplateListBox()
        {
            listBoxTemplates.DataSource = null;
            listBoxTemplates.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"D:\SessionTemplates");
            FileInfo[] files = di.GetFiles("*.xml", SearchOption.TopDirectoryOnly);
            listBoxTemplates.DataSource = files;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the highlighted template?","Confirm Deletion",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string fullPath = Path.Combine(fileDirectory, listBoxTemplates.SelectedItem.ToString());
                try
                {
                    File.Delete(fullPath);
                    MessageBox.Show("Template Deleted Successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    FillTemplateListBox();
                }
            }
        }
    }
}
