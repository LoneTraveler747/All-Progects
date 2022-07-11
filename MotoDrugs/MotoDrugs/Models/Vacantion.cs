using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class Vacantion
    {
        public int? IdVacation { get; set; }
        public DateTime StartVacation { get; set; }
        public DateTime? EndVacation { get; set; }
        public int? IdEmployee { get; set; }
    }
}
