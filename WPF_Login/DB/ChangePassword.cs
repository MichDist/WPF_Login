using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    class ChangePassword : IUserMgt
    {
        // Change the password; pUser should contain the new password! Change it later?
        public Boolean databaseOperation(user pUser, string pConnectionString)
        {
            var connection = new SQLiteConnection(pConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE user SET password = @password WHERE user_id = @user_id";
            command.Parameters.AddWithValue("@password", pUser.getPassword());
            command.Parameters.AddWithValue("@user_id", pUser.getID());
            command.Prepare();

            command.ExecuteNonQuery();

            connection.Close();

            return true;
            
        }
    }
}
