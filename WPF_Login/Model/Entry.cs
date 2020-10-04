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
        public Topic topic { get; set; }
        public string entry_abstract { get; set; }


        public Entry(string pAbstract, Topic pTopic) 
        {
            this.entry_abstract = pAbstract;
            this.topic = pTopic;
        }

    }
}
