using System;
using System.Collections.Generic;

#nullable disable

namespace AZSAPI.Models
{
    public partial class Datum
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AmountOfFuel { get; set; }
        public int RefillId { get; set; }
    }
}
