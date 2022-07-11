using System;
using System.Collections.Generic;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class ClientMan
    {
        public int? IdClient { get; set; }
        public string NameClient { get; set; }
        public string SurnameClient { get; set; }
        public string PatronymicClient { get; set; }
        public int PassportClient { get; set; }
        public int NumberPhone { get; set; }
    }
}
