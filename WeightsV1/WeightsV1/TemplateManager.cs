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
        public TemplateManager()
        {
            InitializeComponent();
            FillTemplateListBox();
        }

        private void FillTemplateListBox()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\SessionTemplates");
            FileInfo[] files = di.GetFiles("*.xml", SearchOption.AllDirectories);
            listBoxTemplates.DataSource = files;
        }
    }
}
