using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class Database
    {
        #region Atteributes
        // Attributes
        private string sConnectionString;
        #endregion

        #region Constructor
        // Constructor
        public Database(string connectionString)
        {
            this.sConnectionString = connectionString;
        }
        #endregion

        #region Get/Set
        // Get/Set
        public string getConnectionString()
        {
            return sConnectionString;
        }
        
        public void setConnectionString(string connectionString)
        {
            this.sConnectionString = connectionString;
        }
        #endregion

        // User
        public user getUserData(user pUser)
        {
            var connection = new SQLiteConnection(sConnectionString);

            connection.Open();

            var command = new SQLiteCommand(connection);

            command.CommandText = "SELECT user_id, user_name, password FROM user WHERE @user_name = user_name";

            command.Parameters.AddWithValue("@user_name", pUser.getName());
            //cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            command.Prepare();

            SQLiteDataReader rdr = command.ExecuteReader();

            user usr = new user();
            // Read result                                  
            while (rdr.Read())
            {
                usr.setName(rdr.GetString(1));
                usr.setPassword(rdr.GetString(2));
            }

            rdr.Close();
            connection.Close();

            return usr;
        }
    }
}