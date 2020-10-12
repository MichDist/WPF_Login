﻿using Serilog;
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

        public Boolean saveEntry(Model.Entry pEntry)
        {
            Log.Information("Start of saveEntry method");

            var connection = new SQLiteConnection(sConnectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);


            connection.Close();

            return true;
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
            Model.Topic topic = new Model.Topic();
            // Read result                                  
            while (rdr.Read())
            {
                topic.topicId = rdr.GetInt32(0);
                topic.topicName = rdr.GetString(1);
                listTopics.Add(topic); 
            }

            rdr.Close();

            connection.Close();

            return listTopics;
        }
    }
}