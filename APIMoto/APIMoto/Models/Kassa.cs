using System;
using System.Collections.Generic;

#nullable disable

namespace APIMoto.Models
{
    public partial class Kassa
    {
        public int? IdKassa { get; set; }
        public DateTime DataStartChange { get; set; }
        public DateTime DateEndChange { get; set; }
        public int IdEmployees { get; set; }
    }
}
