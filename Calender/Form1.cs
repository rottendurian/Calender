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
            hash = hash * 31 * time.Month;
            hash = hash * 31 + time.Day;
            return hash;
        }


    }
        public class Event
        {
            public String Name;
            public int Hour;
            public int Minute;
            public String EventDetails;
            public Event(String name, int hour, int minute, String eventdetails)
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
            public String EventToString()
            {
                return Hour.ToString() + ":" + Minute.ToString() + " " + Name + " : " + EventDetails;
            }
        }













}