using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegLog
{
    [Serializable]
    public class Users
    {
        public List<User> UsersList { get; set; } = new List<User>();
    }
    [Serializable]
    public class User
    {
        public string login1 { get; set; }
        public string password1 { get; set; }
        public string seriaPassport1 { get; set; }
        public string numberPassport1 { get; set; }
        public string numberPhone1 { get; set; }
        public string mail1 { get; set; }

        public User()
        {

        }
        public User(string login, string password, string seriaPassport, string numberPassport, string numberPhone, string mail)
        {
            this.login1 = login;
            this.password1 = password;
            this.seriaPassport1 = seriaPassport;
            this.numberPassport1 = numberPassport;
            this.numberPhone1 = numberPhone;
            this.mail1 = mail;
        }
    }
}
