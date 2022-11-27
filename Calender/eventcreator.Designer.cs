namespace Calender
{
    partial class eventcreator
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(37, 305);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(2);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(113, 24);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Add";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.Location = new System.Drawing.Point(37, 219);
            this.EventNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.Size = new System.Drawing.Size(109, 23);
            this.EventNameTextBox.TabIndex = 1;
            this.EventNameTextBox.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventLabel.Location = new System.Drawing.Point(125, 53);
            this.EventLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(44, 15);
            this.EventLabel.TabIndex = 3;
            this.EventLabel.Text = "Events";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Datelabel.Location = new System.Drawing.Point(131, 11);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(34, 15);
            this.Datelabel.TabIndex = 4;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(155, 305);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.HorizontalScrollbar = true;
            this.EventListBox.ItemHeight = 15;
            this.EventListBox.Location = new System.Drawing.Point(36, 71);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.EventListBox.Size = new System.Drawing.Size(232, 109);
            this.EventListBox.TabIndex = 7;
            this.EventListBox.SelectedIndexChanged += new System.EventHandler(this.EventListBox_SelectedIndexChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(36, 271);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(232, 23);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(68, 201);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(183, 219);
            this.HourTextBox.MaxLength = 2;
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(36, 23);
            this.HourTextBox.TabIndex = 10;
            this.HourTextBox.Text = "23";
            this.HourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(225, 219);
            this.MinutesTextBox.MaxLength = 2;
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(41, 23);
            this.MinutesTextBox.TabIndex = 11;
            this.MinutesTextBox.Text = "22";
            this.MinutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(204, 201);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 15);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Time";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(120, 253);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 14;
            this.DescriptionLabel.Text = "Description";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(102, 185);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(109, 15);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Event Information";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(155, 336);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(111, 24);
            this.ExportButton.TabIndex = 16;
            this.ExportButton.Text = "Export Event";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(36, 336);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(114, 24);
            this.ImportButton.TabIndex = 17;
            this.ImportButton.Text = "Import Event";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // eventcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 369);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventNameTextBox);
            this.Controls.Add(this.ContinueButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "eventcreator";
            this.Text = "New Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private void InitializeComponentsManual()
        {
            this.dateTimePicker1.Value = dt;
            this.HourTextBox.Text = dt.Hour.ToString();
            this.MinutesTextBox.Text = dt.Minute.ToString();
        }
        private void UpdateEventListBox()
        {
            //this.EventListBox.ResetText();
            this.EventListBox.Items.Clear();
            //this.EventListBox.Text = "testing123";
            int hash_id = this.MainForm.MonthDayHashFunction(dt);
            try
            {
                List<Event> temp = this.MainForm.events[hash_id];
                foreach (Event e in temp)
                {
                    this.EventListBox.Items.Add(e.EventToString());
                }
            }
            catch (Exception)
            {

            }

            this.MainForm.UpdateUserControlListBoxes();
            
        }

        private Button ContinueButton;
        private TextBox EventNameTextBox;
        private Label EventLabel;
        private Label Datelabel;
        private DateTimePicker dateTimePicker1;
        private Button RemoveButton;
        private ListBox EventListBox;
        public DateTime dt;
        private Form1 MainForm;
        private TextBox DescriptionTextBox;
        private Label NameLabel;
        private TextBox HourTextBox;
        private TextBox MinutesTextBox;
        private Label label1;
        private Label TimeLabel;
        private Label DescriptionLabel;
        private Label infoLabel;
        private Button ExportButton;
        private Button ImportButton;
    }
}


