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
        public string entry_abstract { get; set; }
        public string topic { get; set; }
        public string title { get; set; }



        public Entry(string pAbstract, string pTopic, string pTitle) 
        {
            this.entry_abstract = pAbstract;
            this.topic = pTopic;
            this.title = pTitle;
            
        }

    }
}
