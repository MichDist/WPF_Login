using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Model
{
    class Entry
    {
        private int id;
        private int user_id;
        private int topic_id;
        public string entry_abstract { get; set; }


        public Entry(string pAbstract) 
        {
            this.entry_abstract = pAbstract;
        }



        //public void setAbstract(string pAbstract)
        //{
        //    this.entry_abstract = pAbstract;
        //}
        //public string getAbstract()
        //{
        //    return this.entry_abstract;
        //}
    }
}
