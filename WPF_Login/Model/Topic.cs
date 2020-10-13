using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Model
{
    class Topic
    {
        public int topicId { get; set; }
        public string topicName { get; set; }

        public Topic() { }
        public Topic(int pTopicId, string pTopicName)
        {
            this.topicName = pTopicName;
            this.topicId = pTopicId;
        }

        public override string ToString()
        {
            return topicName;
        }
    }
}
