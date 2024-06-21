using ModelLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class SchoolDB
    {


        static MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");

        public static void AddEqDB(SchoolClass model)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddSch", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Notification_Id", model.schNotification);
                cmd.Parameters.AddWithValue("@Date", model.schDate);
                cmd.Parameters.AddWithValue("@Time", model.schTime);
                cmd.Parameters.AddWithValue("@Validation", model.schValidation);
                cmd.Parameters.AddWithValue("@Contact", model.schContact);
                cmd.Parameters.AddWithValue("@SMS", model.schSms);
                cmd.Parameters.AddWithValue("@Cell", model.schCell);
                cmd.Parameters.AddWithValue("@Email", model.schEmail);
                cmd.Parameters.AddWithValue("@Picture", model.pictureBox1);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static DataTable SelectAll()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");
            try
            {
                conn.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("ShowAll", conn);
                mySqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static void deleteEq(SchoolClass model)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteSch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@schNotification", model.schNotification);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static void UpdateEq(SchoolClass model)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateSch", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
               
                cmd.Parameters.AddWithValue("@schNotification", model.schNotification);
                cmd.Parameters.AddWithValue("@schDate", model.schDate);
                cmd.Parameters.AddWithValue("@schTime", model.schTime);
                cmd.Parameters.AddWithValue("@schValidation", model.schValidation);
                cmd.Parameters.AddWithValue("@schContact", model.schContact);
                cmd.Parameters.AddWithValue("@schSms", model.schSms);
                cmd.Parameters.AddWithValue("@schCell", model.schCell);
                cmd.Parameters.AddWithValue("@schEmail", model.schEmail);
                cmd.Parameters.AddWithValue("@pictureBox1", model.pictureBox1);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
