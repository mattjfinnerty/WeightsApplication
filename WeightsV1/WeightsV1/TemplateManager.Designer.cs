namespace WeightsV1
{
    partial class TemplateManager
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
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.labelTemplateList = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.Location = new System.Drawing.Point(28, 54);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(478, 329);
            this.listBoxTemplates.TabIndex = 0;
            // 
            // labelTemplateList
            // 
            this.labelTemplateList.AutoSize = true;
            this.labelTemplateList.Location = new System.Drawing.Point(25, 38);
            this.labelTemplateList.Name = "labelTemplateList";
            this.labelTemplateList.Size = new System.Drawing.Size(70, 13);
            this.labelTemplateList.TabIndex = 1;
            this.labelTemplateList.Text = "All Templates";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(592, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(592, 146);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 39);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(592, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TemplateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 396);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTemplateList);
            this.Controls.Add(this.listBoxTemplates);
            this.Name = "TemplateManager";
            this.Text = "TemplateManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTemplates;
        private System.Windows.Forms.Label labelTemplateList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button3;
    }
}