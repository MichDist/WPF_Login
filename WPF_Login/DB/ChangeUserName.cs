using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class ChangeUserName : IUserMgt
    {
        // Change the username; pUser should contain the new username! Change it later?
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
                command.CommandText = "UPDATE user SET user_name = @user_name WHERE user_id = @user_id";
                command.Parameters.AddWithValue("@user_name", pUser.getName());
                command.Parameters.AddWithValue("@user_id", pUser.getID());  
                command.Prepare();

                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
        }
    }
}
