using System;
using System.Collections.Generic;

#nullable disable

namespace AZSAPI.Models
{
    public partial class Refill
    {
        public Refill()
        {
            Data = new HashSet<Datum>();
        }

        public int IdRefill { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Datum> Data { get; set; }
    }
}
