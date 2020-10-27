using Serilog;
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

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("C:\\Users\\Michael Distler\\source\\repos\\logs_wpf\\log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
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
        //public user getUserData(user pUser)
        //{
        //    var connection = new SQLiteConnection(sConnectionString);

        //    connection.Open();

        //    var command = new SQLiteCommand(connection);

        //    command.CommandText = "SELECT user_id, user_name, password FROM user WHERE @user_name = user_name";

        //    command.Parameters.AddWithValue("@user_name", pUser.getName());
        //    //cmd.Parameters.AddWithValue("@password", txtPassword.Text);

        //    command.Prepare();

        //    SQLiteDataReader rdr = command.ExecuteReader();

        //    user usr = new user();
        //    // Read result                                  
        //    while (rdr.Read())
        //    {
        //        usr.setName(rdr.GetString(1));
        //        usr.setPassword(rdr.GetString(2));
        //    }

        //    rdr.Close();
        //    connection.Close();

        //    return usr;
        //}

        public Boolean userNameExists(user pLoginUser)
        {
            var connection = new SQLiteConnection(sConnectionString);
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

            if(result == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean userMgt(user pLoginUser, string pChoice)
        {
            Dictionary<string, IUserMgt> userMgtOperations = new Dictionary<string, IUserMgt>()
            {
                {"CheckUserNameExists", new CheckUserNameExists() },
                {"CheckUserPW", new CheckUserPW() },
                {"CreateNewUser", new CreateNewUser() },
                {"ChangeUsername", new ChangeUserName() },
                {"ChangePassword", new ChangePassword() }
            };

            IUserMgt selectedOperation = userMgtOperations[pChoice];

            return selectedOperation.databaseOperation(pLoginUser, sConnectionString);            
        }

        public user getUserData(user pUser)
        {
            var connection = new SQLiteConnection(sConnectionString);
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

        public List<Model.Topic> getTopics()
        {
            Log.Information("Start of getTopics method");

            List<Model.Topic> listTopics = new List<Model.Topic>();

            var connection = new SQLiteConnection(sConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT id, topic_name FROM topic";
            command.Prepare();

            SQLiteDataReader rdr = command.ExecuteReader();
            // Read result                                  
            while (rdr.Read())
            {
                listTopics.Add(new Model.Topic(rdr.GetInt32(0), rdr.GetString(1))); 
            }

            rdr.Close();

            connection.Close();

            foreach(Model.Topic item in listTopics)
            {
                Log.Debug("AUS METHODE: " + item.topicName);
            }
            Log.Debug("Debug: Content of list: " + listTopics.ToString());
            Log.Information("End: getTopics method");
            return listTopics;
        }

        public Boolean saveEntry(Model.Entry pEntry)
        {
            Boolean result = false;
            Log.Information("Entry object: userId: " + pEntry.user_id + ", typeID: " + pEntry.typeId + ", userID: " + pEntry.user_id + ", title: " + pEntry.title + ", description: " + pEntry.entry_abstract + ", topicNAme: " + pEntry.topic);

            List<Model.Topic> topicList = new List<Model.Topic>();
            topicList = getTopics();
            foreach(Model.Topic topic in topicList)
            {
                if(topic.topicName == pEntry.topic)
                {
                    pEntry.topicId = topic.topicId;
                }
            }
            // No topicID => New topic
            if(pEntry.topicId == 0)
            {
                saveTopic(pEntry.topic);
            }

            // Get topic_id, ugly -> improve later
            topicList = getTopics();
            foreach(Model.Topic topic in topicList)
            {
                if(topic.topicName == pEntry.topic)
                {
                    pEntry.topicId = topic.topicId;
                }
            }


            var connection = new SQLiteConnection(sConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);

            command.CommandText = "INSERT INTO entry(user_id, topic_id, type_id, title, description) " +
                "VALUES(@user_id, @topic_id, @type_id, @title, @desc)";
            command.Parameters.AddWithValue("@user_id", pEntry.user_id);
            command.Parameters.AddWithValue("@topic_id", pEntry.topicId);
            command.Parameters.AddWithValue("@type_id", pEntry.typeId);
            command.Parameters.AddWithValue("@title", pEntry.title);
            command.Parameters.AddWithValue("@topic_id", pEntry.topicId);
            command.Parameters.AddWithValue("@desc", pEntry.entry_abstract);
            //command.Parameters.AddWithValue("@crDatec", ); ;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public Boolean saveTopic(string pTopic)
        {
            Boolean result = true;  // should be false when check if db operation was successfull is implemented
            Log.Information("Start of saveTopic method.");

            var connection = new SQLiteConnection(sConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);

            command.CommandText = "INSERT INTO topic(topic_name) VALUES(@topic)";
            command.Parameters.AddWithValue("@topic", pTopic);
            command.Prepare();

            command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}