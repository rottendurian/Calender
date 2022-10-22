namespace Calender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(344, 75);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(122, 23);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous Month";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(628, 75);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(122, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next Month";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(68, 135);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(955, 500);
            this.dayContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wednsday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(932, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 658);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Name = "Form1";
            this.Text = "Event Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public void setupCalender()
        {
            DateTime today2 = DateTime.Now;
            DateTime today = new DateTime(today2.Year, 1, 1);

            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);

            int days = DateTime.DaysInMonth(today.Year, today.Month);

            int prevMonth = today.Month;
            if (prevMonth != 1)
            {
                prevMonth = DateTime.DaysInMonth(today.Year, today.Month - 1);
            }
            else
            {
                prevMonth = DateTime.DaysInMonth(today.Year, 12);
            }

            int dayOfMonth = Convert.ToInt32(startOfMonth.DayOfWeek);
            int i = dayOfMonth;
            int total = dayOfMonth;
            while (i > 0)
            {
                UserControl1 control = new UserControl1();
                control.BackColor = Color.White;
                control.label1.Text = (prevMonth - i + 1).ToString();

                this.dayContainer.Controls.Add(control);
                i--;
            }
            total += i;
            i = 0;

            while (i < days)
            {
                UserControl1 control = new UserControl1();
                control.label1.Text = (i + 1).ToString();

                this.dayContainer.Controls.Add(control);
                i++;
            }
            total += i;
            i = 0;
            int final = 7 * 6 - total;

            while (i < final)
            {
                UserControl1 control = new UserControl1();
                control.BackColor = Color.White;
                control.label1.Text = (i + 1).ToString();

                this.dayContainer.Controls.Add(control);
                i++;
            }



        }
        private Button prevButton;
        private Button nextButton;
        public FlowLayoutPanel dayContainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}