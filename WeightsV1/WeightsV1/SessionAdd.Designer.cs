namespace WeightsV1
{
    partial class SessionAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionAdd));
            this.listBoxAthletes = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddAthlete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.labelAtheletes = new System.Windows.Forms.Label();
            this.labelSessionDate = new System.Windows.Forms.Label();
            this.comboBoxSessions = new System.Windows.Forms.ComboBox();
            this.labelSessionTemplate = new System.Windows.Forms.Label();
            this.comboBoxReps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAthletes
            // 
            this.listBoxAthletes.FormattingEnabled = true;
            this.listBoxAthletes.Location = new System.Drawing.Point(20, 119);
            this.listBoxAthletes.Name = "listBoxAthletes";
            this.listBoxAthletes.Size = new System.Drawing.Size(169, 186);
            this.listBoxAthletes.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 348);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonAddAthlete
            // 
            this.buttonAddAthlete.Location = new System.Drawing.Point(195, 184);
            this.buttonAddAthlete.Name = "buttonAddAthlete";
            this.buttonAddAthlete.Size = new System.Drawing.Size(96, 53);
            this.buttonAddAthlete.TabIndex = 2;
            this.buttonAddAthlete.Text = "Add Athlete --->";
            this.buttonAddAthlete.UseVisualStyleBackColor = true;
            this.buttonAddAthlete.Click += new System.EventHandler(this.buttonAddAthlete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(659, 184);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(113, 53);
            this.buttonSendData.TabIndex = 4;
            this.buttonSendData.Text = "Add Session To DB";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // labelAtheletes
            // 
            this.labelAtheletes.AutoSize = true;
            this.labelAtheletes.Location = new System.Drawing.Point(20, 100);
            this.labelAtheletes.Name = "labelAtheletes";
            this.labelAtheletes.Size = new System.Drawing.Size(45, 13);
            this.labelAtheletes.TabIndex = 5;
            this.labelAtheletes.Text = "Athletes";
            // 
            // labelSessionDate
            // 
            this.labelSessionDate.AutoSize = true;
            this.labelSessionDate.Location = new System.Drawing.Point(20, 329);
            this.labelSessionDate.Name = "labelSessionDate";
            this.labelSessionDate.Size = new System.Drawing.Size(70, 13);
            this.labelSessionDate.TabIndex = 6;
            this.labelSessionDate.Text = "Session Date";
            // 
            // comboBoxSessions
            // 
            this.comboBoxSessions.FormattingEnabled = true;
            this.comboBoxSessions.Location = new System.Drawing.Point(297, 30);
            this.comboBoxSessions.Name = "comboBoxSessions";
            this.comboBoxSessions.Size = new System.Drawing.Size(297, 21);
            this.comboBoxSessions.TabIndex = 7;
            this.comboBoxSessions.SelectedIndexChanged += new System.EventHandler(this.comboBoxSessions_SelectedIndexChanged);
            // 
            // labelSessionTemplate
            // 
            this.labelSessionTemplate.AutoSize = true;
            this.labelSessionTemplate.Location = new System.Drawing.Point(152, 33);
            this.labelSessionTemplate.Name = "labelSessionTemplate";
            this.labelSessionTemplate.Size = new System.Drawing.Size(139, 13);
            this.labelSessionTemplate.TabIndex = 8;
            this.labelSessionTemplate.Text = "Choose a Session Template";
            // 
            // comboBoxReps
            // 
            this.comboBoxReps.FormattingEnabled = true;
            this.comboBoxReps.Location = new System.Drawing.Point(659, 119);
            this.comboBoxReps.Name = "comboBoxReps";
            this.comboBoxReps.Size = new System.Drawing.Size(113, 21);
            this.comboBoxReps.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Reps";
            // 
            // SessionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReps);
            this.Controls.Add(this.labelSessionTemplate);
            this.Controls.Add(this.comboBoxSessions);
            this.Controls.Add(this.labelSessionDate);
            this.Controls.Add(this.labelAtheletes);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddAthlete);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxAthletes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionAdd";
            this.Text = "SessionAdd";
            this.Load += new System.EventHandler(this.SessionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAthletes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAddAthlete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Label labelAtheletes;
        private System.Windows.Forms.Label labelSessionDate;
        private System.Windows.Forms.ComboBox comboBoxSessions;
        private System.Windows.Forms.Label labelSessionTemplate;
        private System.Windows.Forms.ComboBox comboBoxReps;
        private System.Windows.Forms.Label label1;
    }
}