using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class Employee
    {
        public int? IdEmployee { get; set; }
        public string NameEmployee { get; set; }
        public string SurnameEmployee { get; set; }
        public string PatronymicEmployee { get; set; }
        public string Logins { get; set; }
        public string PasswordEmployee { get; set; }
        public int IdPost { get; set; }
        public bool IsDeleted { get; set; }
    }
}
