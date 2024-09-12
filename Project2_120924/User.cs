using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_120924
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public User(string loginP, string passwordP)
        {
            this.login = loginP;
            this.password = passwordP;
        }
    }
}
