using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitlancer
{
    public class User
    {
        public int id { get; private set; }
        private string fullName { get; set; }
        private string userName { get; set; }
        private string address { get; set; }
        private string userMail { get; set; }
        private bitlancer.userTypes userType { get; set; }
        public List<item> items { get; set; }
        public User(int id, string fullName, string userName, string address, string userMail, bitlancer.userTypes userType)
        {
            this.id = id;
            this.fullName = fullName;
            this.userName = userName;
            this.address = address;
            this.userMail = userMail;
            this.userType = userType;
            this.items = items;
        }
    }
}
