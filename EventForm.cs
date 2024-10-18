using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace CalendarApp
{
    public partial class EventForm : Form
    {
        String connString = "server=localhost;user id=root;password=1234;database=db_calendar;sslmode=none;";

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            String temp = null;

            txdate.Text = UserControlDays.stDay + "/" + Form1.stMonth + "/" + Form1.stYear;

            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                String sql = "SELECT event WHERE date IS '"+ txdate.Text + "' FROM new_table";
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

            if(temp != null)
            {
                txevent.Text = temp;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                String sql = "INSERT INTO new_table(date,event)values(?,?)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("date", txdate.Text);
                cmd.Parameters.AddWithValue("event", txevent.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!");
                cmd.Dispose();
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
        }
    }
}
