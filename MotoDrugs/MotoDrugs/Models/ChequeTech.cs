using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class ChequeTech
    {
        public int? IdChequeTech { get; set; }
        public int IdItem { get; set; }
        public int IdChequeTechPayment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
