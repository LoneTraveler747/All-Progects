using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class Item
    {
        public int? IdItem { get; set; }
        public int IdTypeItem { get; set; }
        public string NameItem { get; set; }
        public double? QuantityItem { get; set; }

    }
}
