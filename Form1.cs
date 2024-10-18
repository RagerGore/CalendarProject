using System.Globalization;

namespace CalendarApp
{
    public partial class Form1 : Form
    {
        int month, year;
        public static string stMonth, stYear;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void UpdateMonthAndYear()
        {
            YearAndMonthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) +" "+ year.ToString();
            stMonth = month.ToString();
            stYear = year.ToString();
        }
        private void displayDays()
        {
            DateTime today = DateTime.Now;
            month = today.Month;
            year = today.Year;
            UpdateMonthAndYear();

            DateTime monthStart = new DateTime(year, month, 1);
            int totMonthDays = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= totMonthDays; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DayContainer.Controls.Add(ucDays);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month--;
            if (month <= 0)
            {
                year--;
                month = 12;
            }
            UpdateMonthAndYear();

            DateTime monthStart = new DateTime(year, month, 1);
            int totMonthDays = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= totMonthDays; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DayContainer.Controls.Add(ucDays);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            UpdateMonthAndYear();

            DateTime monthStart = new DateTime(year, month, 1);
            int totMonthDays = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= totMonthDays; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DayContainer.Controls.Add(ucDays);
            }
        }
    }
}
