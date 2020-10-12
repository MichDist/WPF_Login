using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Model
{
    class Topic
    {
        public int topicId;
        public string topicName;

        public Topic() { }
        public Topic(int pTopicId, string pTopicName)
        {
            this.topicName = pTopicName;
            this.topicId = pTopicId;
        }
    }
}
