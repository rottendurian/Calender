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
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(147, 364);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(119, 40);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(127, 134);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(170, 31);
            this.EventName.TabIndex = 1;
            this.EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(189, 82);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(55, 25);
            this.EventLabel.TabIndex = 3;
            this.EventLabel.Text = "Event";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(189, 232);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(49, 25);
            this.Datelabel.TabIndex = 4;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 31);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // eventcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 510);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.ContinueButton);
            this.Name = "eventcreator";
            this.Text = "New Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ContinueButton;
        private TextBox EventName;
        private Label EventLabel;
        private Label Datelabel;
        private DateTimePicker dateTimePicker1;
    }
}