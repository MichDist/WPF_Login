using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class CreateNewUser : IUserMgt
    {
        // Create new user, return false if username already exists
        public Boolean databaseOperation(user pUser, string pConnectionString)
        {
            var connection = new SQLiteConnection(pConnectionString);
            connection.Open();
            
            Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

            // Check if username already exists
            if (db.userMgt(pUser, "CheckUserNameExists"))
            {
                return false;
            }
            else
            {
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO user(user_name, password) VALUES(@user_name, @password)";
                command.Parameters.AddWithValue("@user_name", pUser.getName());
                command.Parameters.AddWithValue("@password", pUser.getPassword());
                command.Prepare();

                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
        }
    }
}
