namespace WeightsV1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddAthlete = new System.Windows.Forms.Button();
            this.button1AddExcercise = new System.Windows.Forms.Button();
            this.buttonAddExcerciseType = new System.Windows.Forms.Button();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.comboBoxExcercise = new System.Windows.Forms.ComboBox();
            this.buttonTemplateManager = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddAthlete
            // 
            this.buttonAddAthlete.Location = new System.Drawing.Point(48, 53);
            this.buttonAddAthlete.Name = "buttonAddAthlete";
            this.buttonAddAthlete.Size = new System.Drawing.Size(191, 59);
            this.buttonAddAthlete.TabIndex = 0;
            this.buttonAddAthlete.Text = "Add Athlete";
            this.buttonAddAthlete.UseVisualStyleBackColor = true;
            this.buttonAddAthlete.Click += new System.EventHandler(this.buttonAddAthlete_Click);
            // 
            // button1AddExcercise
            // 
            this.button1AddExcercise.Location = new System.Drawing.Point(48, 143);
            this.button1AddExcercise.Name = "button1AddExcercise";
            this.button1AddExcercise.Size = new System.Drawing.Size(191, 59);
            this.button1AddExcercise.TabIndex = 1;
            this.button1AddExcercise.Text = "Add Excercise";
            this.button1AddExcercise.UseVisualStyleBackColor = true;
            this.button1AddExcercise.Click += new System.EventHandler(this.button1AddExcercise_Click);
            // 
            // buttonAddExcerciseType
            // 
            this.buttonAddExcerciseType.Location = new System.Drawing.Point(48, 236);
            this.buttonAddExcerciseType.Name = "buttonAddExcerciseType";
            this.buttonAddExcerciseType.Size = new System.Drawing.Size(191, 59);
            this.buttonAddExcerciseType.TabIndex = 2;
            this.buttonAddExcerciseType.Text = "Add Excercise Type";
            this.buttonAddExcerciseType.UseVisualStyleBackColor = true;
            this.buttonAddExcerciseType.Click += new System.EventHandler(this.buttonAddExcerciseType_Click);
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.Location = new System.Drawing.Point(48, 336);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(184, 59);
            this.buttonAddSession.TabIndex = 3;
            this.buttonAddSession.Text = "Add New Session";
            this.buttonAddSession.UseVisualStyleBackColor = true;
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(342, 80);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(526, 452);
            this.zedGraphControl1.TabIndex = 4;
            // 
            // comboBoxExcercise
            // 
            this.comboBoxExcercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxExcercise.FormattingEnabled = true;
            this.comboBoxExcercise.Location = new System.Drawing.Point(342, 53);
            this.comboBoxExcercise.Name = "comboBoxExcercise";
            this.comboBoxExcercise.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExcercise.TabIndex = 5;
            this.comboBoxExcercise.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcercise_SelectedIndexChanged);
            // 
            // buttonTemplateManager
            // 
            this.buttonTemplateManager.Location = new System.Drawing.Point(48, 432);
            this.buttonTemplateManager.Name = "buttonTemplateManager";
            this.buttonTemplateManager.Size = new System.Drawing.Size(75, 23);
            this.buttonTemplateManager.TabIndex = 6;
            this.buttonTemplateManager.Text = "Template Manager";
            this.buttonTemplateManager.UseVisualStyleBackColor = true;
            this.buttonTemplateManager.Click += new System.EventHandler(this.buttonTemplateManager_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTemplateManager);
            this.Controls.Add(this.comboBoxExcercise);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.buttonAddSession);
            this.Controls.Add(this.buttonAddExcerciseType);
            this.Controls.Add(this.button1AddExcercise);
            this.Controls.Add(this.buttonAddAthlete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Excercise Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAthlete;
        private System.Windows.Forms.Button button1AddExcercise;
        private System.Windows.Forms.Button buttonAddExcerciseType;
        private System.Windows.Forms.Button buttonAddSession;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox comboBoxExcercise;
        private System.Windows.Forms.Button buttonTemplateManager;
        private System.Windows.Forms.Button button1;
    }
}

