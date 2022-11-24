using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class eventcreator : Form
    {
        public eventcreator(DateTime Time, Form1 main_form)
        {
            this.dt = Time;
            this.MainForm = main_form;
            InitializeComponent();
            InitializeComponentsManual();
            UpdateEventListBox();
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {
            string i = EventNameTextBox.Text;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(EventName.Text + "\n" + dateTimePicker1.Value);
            //Close();
            DateTime date = dateTimePicker1.Value;
            int date_id = this.MainForm.MonthDayHashFunction(date);
            Event temp = new Event(EventNameTextBox.Text, 
                Int32.Parse(HourTextBox.Text), 
                Int32.Parse(MinutesTextBox.Text), 
                DescriptionTextBox.Text);

            try
            {
                if (!this.MainForm.events.ContainsKey(date_id))
                {
                    List<Event> array = new List<Event>(1);
                    array.Add(temp);
                    this.MainForm.events.Add(date_id, array);

                }
                else
                {
                    this.MainForm.events[date_id].Add(temp);
                }
                UpdateEventListBox();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid time format");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dt = dateTimePicker1.Value;
            UpdateEventListBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            int date_id = this.MainForm.MonthDayHashFunction(date);

            List<Event> event_list = this.MainForm.events[date_id];

            String name = EventNameTextBox.Text;

            int hour = Int32.Parse(HourTextBox.Text);
            int minute = Int32.Parse(MinutesTextBox.Text);

            int size = event_list.Count();
            List<int> remove_list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (event_list[i].Name == name || (event_list[i].Hour == hour && event_list[i].Minute == minute)) {
                    remove_list.Add(i);
                } 
            }
            foreach (int i in remove_list)
            {
                event_list.RemoveAt(i);
            }

            UpdateEventListBox();

        }
    }
}
