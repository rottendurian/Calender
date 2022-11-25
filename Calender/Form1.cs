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
            listBox1.Items.Clear();
            int hash = MonthDayHashFunction(DateTime.Today);
            List<Event> eventList;
            bool result = events.TryGetValue(hash, out eventList);
            if (result)
            {
                foreach (Event e in eventList)
                {
                    listBox1.Items.Add(e.EventToString());
                }
            }

            foreach (UserControl1 u in this.userControlReferences) 
            {
                u.UpdateTreeView();
            }
        }


    }
    public class Event
    {
        public string Name;
        public int Hour;
        public int Minute;
        public string EventDetails;
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
    }



}