using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class RecoveryEmployee
    {
        public int? IdRecoveryEmployee { get; set; }
        public int IdEmployee { get; set; }
        public int? IdRecovery { get; set; }

    }
}
