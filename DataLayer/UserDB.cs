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
    public class UserDB
    {



        static MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=schooldatabase");
        public static UserClass GetUserVerifiedDB(UserClass user)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("loginDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", user.User);
                    cmd.Parameters.AddWithValue("@pass", user.Pass);

                    cmd.Parameters.Add("@uname", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@upass", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    if ((UInt64)cmd.Parameters["@uname"].Value == 1)
                        user.uname = true;
                    if ((UInt64)cmd.Parameters["@upass"].Value == 1)
                        user.upass = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("DataBase Error, " + ex.Message);

            }
            return user;





        }
    }


}

