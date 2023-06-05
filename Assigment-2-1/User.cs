using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2_1
{
    public class User
    {
        public string name { get; set; }
        public bool chkClean { get; set; }

        public bool chkWhitening { get; set; }
        public bool chkXray { get; set; }

        public int number { get; set; }
        public User()
        {
            
        }

        public User(string name, bool chkClean, bool chkWhitening, bool chkXray, int number)
        {
            this.name = name;
            this.chkClean = chkClean;
            this.chkWhitening = chkWhitening;
            this.chkXray = chkXray;
            this.number = number;
        }
    }
}
