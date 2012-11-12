namespace WeightsV1
{
    partial class AthleteAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthleteAdd));
            this.textBoxForename = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.buttonAthlete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForename
            // 
            this.textBoxForename.Location = new System.Drawing.Point(31, 49);
            this.textBoxForename.Name = "textBoxForename";
            this.textBoxForename.Size = new System.Drawing.Size(167, 20);
            this.textBoxForename.TabIndex = 0;
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.Location = new System.Drawing.Point(28, 33);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(54, 13);
            this.labelForename.TabIndex = 1;
            this.labelForename.Text = "Forename";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(250, 49);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(152, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(250, 30);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(464, 49);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(89, 20);
            this.textBoxWeight.TabIndex = 4;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(464, 29);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight (KG)";
            // 
            // buttonAthlete
            // 
            this.buttonAthlete.Location = new System.Drawing.Point(401, 105);
            this.buttonAthlete.Name = "buttonAthlete";
            this.buttonAthlete.Size = new System.Drawing.Size(152, 37);
            this.buttonAthlete.TabIndex = 6;
            this.buttonAthlete.Text = "Add Athlete to Application";
            this.buttonAthlete.UseVisualStyleBackColor = true;
            this.buttonAthlete.Click += new System.EventHandler(this.buttonAthlete_Click);
            // 
            // AthleteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 173);
            this.Controls.Add(this.buttonAthlete);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelForename);
            this.Controls.Add(this.textBoxForename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AthleteAdd";
            this.Text = "AthleteAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForename;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button buttonAthlete;
    }
}