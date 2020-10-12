using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Model
{
    class Entry
    {
        public int id;
        public int user_id;
        private int topicId { get; set; }
        private int typeId { get; set; }
        public string entry_abstract { get; set; }
        public string topic { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string userName { get; set; }


        public Entry(string pAbstract, string pTopic, string pTitle) 
        {
            this.entry_abstract = pAbstract;
            this.topic = pTopic;
            this.title = pTitle;
           
        }

        public Entry(string pAbstract, string pTopic, string pTitle, string pType, string pContent, int pUserId, string pUserName)
        {
            this.entry_abstract = pAbstract;
            this.topic = pTopic;
            this.title = pTitle;
            this.type = pType;
            this.content = pContent;
            this.user_id = pUserId;
            this.userName = pUserName;
        }
    }
}
