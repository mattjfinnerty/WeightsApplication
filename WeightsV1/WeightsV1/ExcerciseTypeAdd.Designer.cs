namespace WeightsV1
{
    partial class ExcerciseTypeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcerciseTypeAdd));
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxExcerciseType = new System.Windows.Forms.TextBox();
            this.buttonAddExcerciseType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(46, 41);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description";
            // 
            // textBoxExcerciseType
            // 
            this.textBoxExcerciseType.Location = new System.Drawing.Point(49, 58);
            this.textBoxExcerciseType.Name = "textBoxExcerciseType";
            this.textBoxExcerciseType.Size = new System.Drawing.Size(254, 20);
            this.textBoxExcerciseType.TabIndex = 1;
            this.textBoxExcerciseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExcerciseType_KeyPress);
            // 
            // buttonAddExcerciseType
            // 
            this.buttonAddExcerciseType.Location = new System.Drawing.Point(325, 51);
            this.buttonAddExcerciseType.Name = "buttonAddExcerciseType";
            this.buttonAddExcerciseType.Size = new System.Drawing.Size(113, 32);
            this.buttonAddExcerciseType.TabIndex = 2;
            this.buttonAddExcerciseType.Text = "Add Excercise Type";
            this.buttonAddExcerciseType.UseVisualStyleBackColor = true;
            this.buttonAddExcerciseType.Click += new System.EventHandler(this.buttonAddExcerciseType_Click);
            // 
            // ExcerciseTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 173);
            this.Controls.Add(this.buttonAddExcerciseType);
            this.Controls.Add(this.textBoxExcerciseType);
            this.Controls.Add(this.labelDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcerciseTypeAdd";
            this.Text = "ExcerciseTypeAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxExcerciseType;
        private System.Windows.Forms.Button buttonAddExcerciseType;
    }
}