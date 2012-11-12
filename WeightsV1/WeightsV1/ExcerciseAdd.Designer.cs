namespace WeightsV1
{
    partial class ExcerciseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcerciseAdd));
            this.labelExcerciseName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAddExcercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExcerciseName
            // 
            this.labelExcerciseName.AutoSize = true;
            this.labelExcerciseName.Location = new System.Drawing.Point(42, 40);
            this.labelExcerciseName.Name = "labelExcerciseName";
            this.labelExcerciseName.Size = new System.Drawing.Size(84, 13);
            this.labelExcerciseName.TabIndex = 0;
            this.labelExcerciseName.Text = "Excercise Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(45, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(45, 138);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(233, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(42, 110);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(80, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Excercise Type";
            // 
            // buttonAddExcercise
            // 
            this.buttonAddExcercise.Location = new System.Drawing.Point(318, 128);
            this.buttonAddExcercise.Name = "buttonAddExcercise";
            this.buttonAddExcercise.Size = new System.Drawing.Size(114, 38);
            this.buttonAddExcercise.TabIndex = 4;
            this.buttonAddExcercise.Text = "Add Excercise";
            this.buttonAddExcercise.UseVisualStyleBackColor = true;
            this.buttonAddExcercise.Click += new System.EventHandler(this.buttonAddExcercise_Click);
            // 
            // ExcerciseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.Controls.Add(this.buttonAddExcercise);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelExcerciseName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcerciseAdd";
            this.Text = "ExcerciseAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExcerciseName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonAddExcercise;
    }
}