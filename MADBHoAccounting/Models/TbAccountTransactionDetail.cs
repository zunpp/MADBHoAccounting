using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbAccountTransactionDetail
    {
        public int AccountPkid { get; set; }
        public string AccountMainTitleCode { get; set; }
        public string AccountSubTitleCode { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AccountCashTypeId { get; set; }
        public string AccountTypeForHo { get; set; }
        public string LocationOfAccountTypeForHo { get; set; }
        public string Description { get; set; }
        public string TownshipId { get; set; }
        public string RegionId { get; set; }
        public string StateDivisionId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
