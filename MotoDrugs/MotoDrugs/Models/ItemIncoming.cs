using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class ItemIncoming
    {
        public int? IdIncoming { get; set; }
        public int IdItem { get; set; }
        public int IdProvider { get; set; }
        public DateTime DateSending { get; set; }
        public int CostItem { get; set; }
    }
}
