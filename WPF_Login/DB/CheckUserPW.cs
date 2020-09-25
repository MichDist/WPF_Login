using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class CheckUserPW : IUserMgt
    {
        // Check whether user pw is correct
        public Boolean databaseOperation(user pLoginUser, string pConnectionString)
        {
            var connection = new SQLiteConnection(pConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT password FROM user WHERE @user_name = user_name";
            command.Parameters.AddWithValue("@user_name", pLoginUser.getName());
            command.Prepare();

            SQLiteDataReader rdr = command.ExecuteReader();
            string result = "";
            // Read result                                  
            while (rdr.Read())
            {
                result = rdr.GetString(0);
            }

            rdr.Close();
            connection.Close();

            if (result == pLoginUser.getPassword())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
