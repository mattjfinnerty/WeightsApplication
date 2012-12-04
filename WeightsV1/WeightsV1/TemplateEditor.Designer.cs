namespace WeightsV1
{
    partial class TemplateEditor
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
            this.textBoxTemplateName = new System.Windows.Forms.TextBox();
            this.labelTextBoxName = new System.Windows.Forms.Label();
            this.buttonAddExcercise = new System.Windows.Forms.Button();
            this.labelRestrictType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxRestrict = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxTemplateName
            // 
            this.textBoxTemplateName.Location = new System.Drawing.Point(180, 30);
            this.textBoxTemplateName.Name = "textBoxTemplateName";
            this.textBoxTemplateName.Size = new System.Drawing.Size(232, 20);
            this.textBoxTemplateName.TabIndex = 0;
            // 
            // labelTextBoxName
            // 
            this.labelTextBoxName.AutoSize = true;
            this.labelTextBoxName.Location = new System.Drawing.Point(52, 33);
            this.labelTextBoxName.Name = "labelTextBoxName";
            this.labelTextBoxName.Size = new System.Drawing.Size(122, 13);
            this.labelTextBoxName.TabIndex = 1;
            this.labelTextBoxName.Text = "Session Template Name";
            // 
            // buttonAddExcercise
            // 
            this.buttonAddExcercise.Location = new System.Drawing.Point(55, 130);
            this.buttonAddExcercise.Name = "buttonAddExcercise";
            this.buttonAddExcercise.Size = new System.Drawing.Size(75, 23);
            this.buttonAddExcercise.TabIndex = 2;
            this.buttonAddExcercise.Text = "Add";
            this.buttonAddExcercise.UseVisualStyleBackColor = true;
            this.buttonAddExcercise.Click += new System.EventHandler(this.buttonAddExcercise_Click);
            // 
            // labelRestrictType
            // 
            this.labelRestrictType.AutoSize = true;
            this.labelRestrictType.Location = new System.Drawing.Point(36, 80);
            this.labelRestrictType.Name = "labelRestrictType";
            this.labelRestrictType.Size = new System.Drawing.Size(138, 13);
            this.labelRestrictType.TabIndex = 3;
            this.labelRestrictType.Text = "Restrict To Excercise Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(180, 77);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // checkBoxRestrict
            // 
            this.checkBoxRestrict.AutoSize = true;
            this.checkBoxRestrict.Location = new System.Drawing.Point(308, 80);
            this.checkBoxRestrict.Name = "checkBoxRestrict";
            this.checkBoxRestrict.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRestrict.TabIndex = 5;
            this.checkBoxRestrict.UseVisualStyleBackColor = true;
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 549);
            this.Controls.Add(this.checkBoxRestrict);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelRestrictType);
            this.Controls.Add(this.buttonAddExcercise);
            this.Controls.Add(this.labelTextBoxName);
            this.Controls.Add(this.textBoxTemplateName);
            this.Name = "TemplateEditor";
            this.Text = "TemplateEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemplateName;
        private System.Windows.Forms.Label labelTextBoxName;
        private System.Windows.Forms.Button buttonAddExcercise;
        private System.Windows.Forms.Label labelRestrictType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxRestrict;
    }
}