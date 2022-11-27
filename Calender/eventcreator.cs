﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            for (int i = size - 1; i >= 0; i--)
            {
                if (event_list[i].Name == name)
                { //|| (event_list[i].Hour == hour && event_list[i].Minute == minute) removed becuz bad
                    event_list.RemoveAt(i);
                }
            }

            UpdateEventListBox();

        }

        private void EventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        struct CurrentEventStruct
        {
            public Event e { get; set; }
            public int date_id { get; set; }
            public CurrentEventStruct(Event e, int date_id)
            {
                this.e = e;
                this.date_id = date_id;
            }
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            string json = Clipboard.GetText();

            List<CurrentEventStruct> importEvents = JsonSerializer.Deserialize<List<CurrentEventStruct>>(json);

            foreach (var importEvent in importEvents)
            {
                this.MainForm.events[importEvent.date_id].Add(importEvent.e);
            }

            UpdateEventListBox();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            int index = EventListBox.SelectedIndex;
            var selected = EventListBox.SelectedIndices;

            List<CurrentEventStruct> exportEvents = new List<CurrentEventStruct>();

            DateTime date = dateTimePicker1.Value;

            foreach (int selection in selected)
            {
                int date_id = this.MainForm.MonthDayHashFunction(date);
                Event curEvent = this.MainForm.events[date_id][selection];
                CurrentEventStruct exportEvent = new CurrentEventStruct(curEvent, date_id);

                exportEvents.Add(exportEvent);

            }
            string json = JsonSerializer.Serialize(exportEvents);

            Clipboard.SetText(json);

                
            
        }
    }
}
