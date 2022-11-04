using System.Windows.Forms;

namespace Calender
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int id, Form1 form, DateTime date)
        {
      
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "30";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Name = "UserControl"+id.ToString();
            this.Size = new System.Drawing.Size(130, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void InitializeComponentsManual(Form1 form, DateTime date)
        {
            this.BackColor = Color.White;
            this.label1.Text = (date.Day).ToString();
            this.formRef = form;
            this.date = date;
            this.Click += new EventHandler(this.UserControlClicked);

            foreach (Control c in this.Controls)
                c.Click += new EventHandler(this.UserControlClicked);
        }

        public void UpdateComponents(Form1 form, DateTime date)
        {
            this.BackColor = Color.White;
            this.label1.Text = (date.Day).ToString();
            this.date = date;
        }

        

        #endregion
        private Form1 formRef;
        private DateTime date;
        public Label label1;
    }
}
