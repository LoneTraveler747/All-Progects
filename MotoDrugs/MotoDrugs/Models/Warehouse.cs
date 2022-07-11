using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class Warehouse
    {
        public int? IdItemsInWarehouse { get; set; }
        public int IdItemForWarhouse { get; set; }
        public double? QuantityWarehouse { get; set; }

    }
}
