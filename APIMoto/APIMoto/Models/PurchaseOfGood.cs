using System;
using System.Collections.Generic;

#nullable disable

namespace APIMoto.Models
{
    public partial class PurchaseOfGood
    {
        public int? IdParachase { get; set; }
        public DateTime Data { get; set; }
        public int ArticleNumber { get; set; }
        public int ValuesOfGoods { get; set; }
        public int Quantity { get; set; }
    }
}
