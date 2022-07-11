using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class Salary
    {
        public int? IdSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public decimal? MinSalary { get; set; }
    }
}
