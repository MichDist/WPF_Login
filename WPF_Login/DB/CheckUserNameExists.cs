using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class CheckUserNameExists : IUserMgt
    {
        // Check whether username exists
        public Boolean databaseOperation(user pLoginUser, string pConnectionString)
        {
            var connection = new SQLiteConnection(pConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT user_name FROM user WHERE @user_name = user_name";
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

            if (result == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
