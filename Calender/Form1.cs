namespace Calender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setupCalender(-3);
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
            eventcreator ec = new eventcreator();
            ec.Show();

        }
    }













}