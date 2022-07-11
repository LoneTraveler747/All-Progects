using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class AllowanceEmployee
    {
        public int? IdAllowanceEmployee { get; set; }
        public int IdEmployee { get; set; }
        public int? IdAllowance { get; set; }

    }
}
