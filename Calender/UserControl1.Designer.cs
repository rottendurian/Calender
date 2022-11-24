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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 45);
            this.listBox1.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(130, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public void InitializeComponentsManual(Form1 form, DateTime date)
        {
            this.BackColor = Color.White;
            this.label1.Text = (date.Day).ToString();
            this.formRef = form;
            this.date = date;
            this.Click += new EventHandler(this.UserControlClicked);

            foreach (Control c in this.Controls)
                c.Click += new EventHandler(this.UserControlClicked);

            //this.listBox1.Click += new EventHandler(this.UserControlClicked);

            UpdateTreeView();
        }

        public void UpdateComponents(Form1 form, DateTime date)
        {
            this.BackColor = Color.White;
            this.label1.Text = (date.Day).ToString();
            this.date = date;
            UpdateTreeView();
        }

        public void UpdateTreeView()
        {
            this.listBox1.Items.Clear();

            int hash = formRef.MonthDayHashFunction(date);

            List<Event> events;// = formRef.events[hash];
            bool found = formRef.events.TryGetValue(hash,out events);
            
            if (found)
            {
                foreach (Event e in events)
                {
                    this.listBox1.Items.Add(e.UserControlToString());
                }
            }

            ////this.listBox1.Items.Add("Testing12345");

            //try
            //{

            //    foreach (Event e in events)
            //    {
            //        this.listBox1.Items.Add(e.Name);
            //    }
            //} catch
            //{

            //}

        }

        

        
        private Form1 formRef;
        private DateTime date;
        public Label label1;
        private ListBox listBox1;
    }
}
