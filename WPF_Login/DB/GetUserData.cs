using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class GetUserData 
    {
        // Get user data
        public user getUserData(user pUser, string pConnectionString)
        {
            var connection = new SQLiteConnection(pConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT user_id, user_name, password FROM user WHERE @user_name = user_name";
            command.Parameters.AddWithValue("@user_name", pUser.getName());
            command.Prepare();

            SQLiteDataReader rdr = command.ExecuteReader();
            
            // Read result                                  
            while (rdr.Read())
            {
                pUser.setID(rdr.GetInt32(0));
                pUser.setName(rdr.GetString(1));
                pUser.setPassword(rdr.GetString(2));
            }

            rdr.Close();
            connection.Close();

            return pUser;
        }
    }
}
