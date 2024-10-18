using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalendarApp
{
    public partial class UserControlDays : UserControl
    {
        string connString = "server=localhost;user id=root;password=1234;database=db_calendar;sslmode=none;";

        public static string stDay;

        private void EventForm_Load(object sender, EventArgs e)
        {
            string temp = null, tempDate = UserControlDays.stDay + "/" + Form1.stMonth + "/" + Form1.stYear; ;

            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "SELECT event WHERE date IS '" + tempDate + "' FROM new_table";
                MySqlCommand cmd = conn.CreateCommand();
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        temp = dr.GetString(0);
                    }
                }
                cmd.Dispose();
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            if (temp != null)
            {
                TemporaryText.Text = temp;
            }
        }

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numDay)
        {
            DayNumber.Text = numDay.ToString() + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            stDay = DayNumber.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
