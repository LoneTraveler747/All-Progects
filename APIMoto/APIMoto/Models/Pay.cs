using System;
using System.Collections.Generic;

#nullable disable

namespace APIMoto.Models
{
    public partial class Pay
    {
        public int? IdPay { get; set; }
        public DateTime Date { get; set; }
        public int IdTovara { get; set; }
        public int IdEmployees { get; set; }
        public int IdNameMagazin { get; set; }
        public int Count { get; set; }
    }
}
