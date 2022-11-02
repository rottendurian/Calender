using System.Text;
using System.Windows.Forms;

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
            this.MonthLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.testEventOpener = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(423, 52);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(174, 38);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous Month";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(997, 52);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(174, 38);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next Month";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(97, 225);
            this.dayContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1364, 833);
            this.dayContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1131, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wednsday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1331, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthLabel.Location = new System.Drawing.Point(723, 113);
            this.MonthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(156, 40);
            this.MonthLabel.TabIndex = 10;
            this.MonthLabel.Text = "September";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testEventOpener
            // 
            this.testEventOpener.AutoSize = true;
            this.testEventOpener.Location = new System.Drawing.Point(150, 48);
            this.testEventOpener.Name = "testEventOpener";
            this.testEventOpener.Size = new System.Drawing.Size(140, 25);
            this.testEventOpener.TabIndex = 12;
            this.testEventOpener.Text = "testeventopener";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 1097);
            this.Controls.Add(this.testEventOpener);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonthLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Event Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public void setupCalender(int date_offset)
        {
            DateTime today2 = DateTime.Now;
            today2 = today2.AddMonths(date_offset);
            MonthLabel.Text = MonthArray[today2.Month - 1] + " " + today2.Year;

            DateTime today = new DateTime(today2.Year, today2.Month, 1);

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
            int total_val = 0;
            while (i > 0)
            {
                UserControl1 control = new UserControl1(total_val);
                control.BackColor = Color.White;
                control.label1.Text = (prevMonth - i + 1).ToString();
                this.userControlReferences[total_val] = control;
                this.dayContainer.Controls.Add(control);
                i--;
                total_val++;


            }
            total += i;
            i = 0;

            while (i < days)
            {
                UserControl1 control = new UserControl1(total_val);
                control.label1.Text = (i + 1).ToString();
                this.userControlReferences[total_val] = control;
                this.dayContainer.Controls.Add(control);
                i++;
                total_val++;
            }
            total += i;
            i = 0;
            int final = 7 * 6 - total;

            while (i < final)
            {
                UserControl1 control = new UserControl1(total_val);
                control.BackColor = Color.White;
                control.label1.Text = (i + 1).ToString();
                this.userControlReferences[total_val] = control;
                this.dayContainer.Controls.Add(control);
                i++;
                total_val++;
            }


        }
        public void updateCalender(int date_offset)
        {
            DateTime today2 = DateTime.Now;
            today2 = today2.AddMonths(date_offset);
            MonthLabel.Text = MonthArray[today2.Month - 1] + " " + today2.Year;

            DateTime today = new DateTime(today2.Year, today2.Month, 1);

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
            int total_val = 0;
            while (i > 0)
            {
                this.userControlReferences[total_val].BackColor = Color.White;
                this.userControlReferences[total_val].label1.Text = (prevMonth - i + 1).ToString();

                
                i--;
                total_val++;


            }
            total += i;
            i = 0;

            while (i < days)
            {
                this.userControlReferences[total_val].BackColor = System.Drawing.SystemColors.ActiveCaption;
                this.userControlReferences[total_val].label1.Text = (i + 1).ToString();
                i++;
                total_val++;
            }
            total += i;
            i = 0;
            int final = 7 * 6 - total;

            while (i < final)
            {
                this.userControlReferences[total_val].BackColor = Color.White;
                this.userControlReferences[total_val].label1.Text = (i + 1).ToString();
                i++;
                total_val++;
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
        private Label MonthLabel;
        private int CurrentMonth;
        private String[] MonthArray =
        {
            "January", 
            "February", 
            "March", 
            "April", 
            "May", 
            "June", 
            "July", 
            "August", 
            "September", 
            "October", 
            "November", 
            "December"
        };
        private UserControl1[] userControlReferences = new UserControl1[42];
        private Button button1;
        private Label testEventOpener;
    }
}
//DateTime today2 = DateTime.Now;
////today2 = today2.AddMonths(date_offset);
//CurrentMonth = date_offset;
//MonthLabel.Text = MonthArray[today2.Month - 1] + " " + today2.Year;

//DateTime today = new DateTime(today2.Year, today2.Month, 1);

//DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);

//int days = DateTime.DaysInMonth(today.Year, today.Month);

//int prevMonth = today.Month;
//if (prevMonth != 1)
//{
//    prevMonth = DateTime.DaysInMonth(today.Year, today.Month - 1);
//}
//else
//{
//    prevMonth = DateTime.DaysInMonth(today.Year, 12);
//}

//int dayOfMonth = Convert.ToInt32(startOfMonth.DayOfWeek);
//int i = dayOfMonth;
//int total = dayOfMonth;

//int total_count = 0;
//while (i > 0)
//{
//    UserControl1 control = new UserControl1(total_count);
//    control.BackColor = Color.White;
//    control.label1.Text = (prevMonth - i + 1).ToString();

//    //userControlReferences[total_count] = control;

//    this.dayContainer.Controls.Add(control);
//    i--;
//    total_count++;
//}
//total += i;
//i = 0;

//while (i < days)
//{
//    UserControl1 control = new UserControl1(total_count);
//    control.label1.Text = (i + 1).ToString();
//    //userControlReferences[total_count] = control;

//    this.dayContainer.Controls.Add(control);
//    i++;
//    total_count++;
//}
//total += i;
//i = 0;
//int final = 7 * 6 - total;

//while (i < final)
//{
//    UserControl1 control = new UserControl1(total_count);
//    control.BackColor = Color.White;
//    control.label1.Text = (i + 1).ToString();
//   // userControlReferences[total_count] = control;

//    this.Controls.Add(control);

//    i++;
//    total_count++;
//}