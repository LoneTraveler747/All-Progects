using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class ChequeTechPayment
    {

        public int? IdCeque { get; set; }
        public int IdEmployee { get; set; }
        public int IdClient { get; set; }
        public string Addressr { get; set; }
        public int IdTypePayment { get; set; }
        public bool IsDeleted { get; set; }

    }
}
