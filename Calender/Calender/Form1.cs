using System.Text.Json;
using System.Text.Json.Serialization;

namespace Calender
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeDictionary();
            InitializeComponent();
            setupCalender(0);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveEvents("res/default.json");
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            CurrentMonth -= 1;
            updateCalender(CurrentMonth);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            CurrentMonth += 1;
            updateCalender(CurrentMonth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventcreator ec = new eventcreator(DateTime.Now,this);
            ec.Show();

        }
        public int MonthDayHashFunction(DateTime time)
        {
            int hash = 23;
            hash = hash * 31 + time.Year;
            hash = hash * 31 + time.Month;
            hash = hash * 31 + time.Day;
            return hash;
        }
        public void UpdateUserControlListBoxes()
        {
            //listBox1.Items.Clear();
            label8.Text = "";
            int hash = MonthDayHashFunction(DateTime.Today);
            List<Event> eventList;
            bool result = events.TryGetValue(hash, out eventList);

            int eventCount = 0;

            if (result)
            {
                foreach (Event e in eventList)
                {
                    if (eventCount >= 3)
                    {
                        break;
                    }
                    label8.Text += e.EventToString() + "\n";
                    eventCount++;
                    //listBox1.Items.Add(e.EventToString());
                }
            }

            foreach (UserControl1 u in this.userControlReferences) 
            {
                u.UpdateTreeView();
            }
        }

        public void saveEvents(string filename)
        {
            string json = JsonSerializer.Serialize(events);
            System.IO.File.WriteAllText(filename, json);
        }

        public void loadEvents()
        {
            string json = System.IO.File.ReadAllText("res/default.json");
            events = JsonSerializer.Deserialize<Dictionary<int, List<Event>>>(json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveEvents("res/default.json");
        }
    }
    public class Event
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string EventDetails { get; set; }
        public Event(string name, int hour, int minute, string eventdetails)
        {
            Name = name;
            if (hour > 23 || minute > 59 || hour < 0 || minute < 0)
            {
                throw new ArgumentException("Invalid hour/minutes");
            }
            Hour = hour;
            Minute = minute;
            EventDetails = eventdetails;
        }
        public string EventToString()
        {
            return Hour.ToString() + ":" + Minute.ToString() + " " + Name + " : " + EventDetails;
        }

        public string UserControlToString()
        {
            return Hour.ToString() + ":" + Minute.ToString() + " " + Name;
        }

        public int SortEventFunction()
        {
            int reslt = Hour * 10 + Minute;
            return reslt;
        }

        
    }



}