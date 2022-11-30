using System.Collections;
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
            this.label8 = new System.Windows.Forms.Label();
            this.UpcomingEventLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(247, 91);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(122, 23);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous Month";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(720, 89);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(122, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next Month";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(68, 143);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(955, 500);
            this.dayContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wednsday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(930, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.BackColor = System.Drawing.Color.Transparent;
            this.MonthLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthLabel.Location = new System.Drawing.Point(68, 87);
            this.MonthLabel.MinimumSize = new System.Drawing.Size(955, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(955, 25);
            this.MonthLabel.TabIndex = 10;
            this.MonthLabel.Text = "September";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(68, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MinimumSize = new System.Drawing.Size(955, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(955, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "12:30 Sample Event: sample event idk";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpcomingEventLabel
            // 
            this.UpcomingEventLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpcomingEventLabel.AutoSize = true;
            this.UpcomingEventLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpcomingEventLabel.Location = new System.Drawing.Point(68, 1);
            this.UpcomingEventLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpcomingEventLabel.MinimumSize = new System.Drawing.Size(955, 10);
            this.UpcomingEventLabel.Name = "UpcomingEventLabel";
            this.UpcomingEventLabel.Size = new System.Drawing.Size(955, 21);
            this.UpcomingEventLabel.TabIndex = 16;
            this.UpcomingEventLabel.Text = "Upcoming Events:";
            this.UpcomingEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.UpcomingEventLabel);
            this.Controls.Add(this.label8);
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
            this.Name = "Form1";
            this.Text = "Event Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public void InitializeDictionary()
        {
            this.events = new Dictionary<int, List<Event>>();
            loadEvents();
        }
        public void setupCalender(int month_offset)
        {
            DateTime today = DateTime.Now;
            today = today.AddMonths(month_offset);
            today = new DateTime(today.Year, today.Month, 1);

            MonthLabel.Text = MonthArray[today.Month - 1] + " " + today.Year;


            int cur_month = today.Month;
            int days_into_prev_month = Convert.ToInt32(today.DayOfWeek);

            today = today.AddDays(-days_into_prev_month);
            

            int total_value = 0;
            while (total_value < 42)
            {
                UserControl1 control = new UserControl1(0, this, today);
                this.userControlReferences[total_value] = control;
                this.dayContainer.Controls.Add(control);
                today = today.AddDays(1);
                total_value++;
                
            }
            UpdateUserControlListBoxes();
        }//
        public void updateCalender(int month_offset)
        {
            DateTime today = DateTime.Today;
            today = today.AddMonths(month_offset);
            today = new DateTime(today.Year, today.Month, 1);

            MonthLabel.Text = MonthArray[today.Month - 1] + " " + today.Year;


            int cur_month = today.Month;
            int days_into_prev_month = Convert.ToInt32(today.DayOfWeek);

            today = today.AddDays(-days_into_prev_month);


            int total_value = 0;
            while (total_value < 42)
            {
                this.userControlReferences[total_value].UpdateComponents(this,today);
                today = today.AddDays(1);
                total_value++;

            }
        }

        public void SortDictionary(DateTime day)
        {
            int index = MonthDayHashFunction(day);

            events[index].Sort((x,y) => x.SortEventFunction().CompareTo(y.SortEventFunction()));

        }

        public void SortDictionary(int index)
        {
            events[index].Sort((x, y) => x.SortEventFunction().CompareTo(y.SortEventFunction()));
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
        public Dictionary<int,List<Event>> events;
        private Label label8;
        private Label UpcomingEventLabel;
    }

    public class MyListBox : System.Windows.Forms.ListBox
    {
        private bool mShowScroll;
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!mShowScroll)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return mShowScroll; }
            set
            {
                if (value != mShowScroll)
                {
                    mShowScroll = value;
                    if (IsHandleCreated)
                        RecreateHandle();
                }
            }
        }
    }


}
