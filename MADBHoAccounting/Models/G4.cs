using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class G4
    {
        public DateTime? Date { get; set; }
        public string TownCode { get; set; }
        public string AccountCode { get; set; }
        public string MiniAccount { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
    }
}
