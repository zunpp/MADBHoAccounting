using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwCashScrollDr
    {
        public string TransactionDate { get; set; }
        public string AccountMainTitleInEnglish { get; set; }
        public decimal Debit { get; set; }
    }
}
