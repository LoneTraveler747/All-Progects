using System;
using System.Collections.Generic;

#nullable disable

namespace APIMoto.Models
{
    public partial class Employee
    {
        public int? IdEmployees { get; set; }
        public int Position { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PassportData { get; set; }
        public string Logins { get; set; }
        public string PasswordEmployee { get; set; }
    }
}
