using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwAccountDetail
    {
        public int AccountId { get; set; }
        public DateTime? Date { get; set; }
        public string TownCode { get; set; }
        public string TownName { get; set; }
        public string DiviSionName { get; set; }
        public string AccountCode { get; set; }
        public string SubsiHeadName { get; set; }
        public string MiniAccount { get; set; }
        public string MainHeadName { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string GroupNumber { get; set; }
    }
}
