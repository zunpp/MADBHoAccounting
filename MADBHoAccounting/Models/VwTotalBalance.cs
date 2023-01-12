using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwTotalBalance
    {
        public int TotalBalancePkid { get; set; }
        public decimal? OpenDebitTotalBalance { get; set; }
        public decimal? CloseDebitTotalBalance { get; set; }
        public decimal? OpenCreditTotalBalance { get; set; }
        public decimal? CloseCreditTotalBalance { get; set; }
        public decimal? OpenCashDebitTotalBalance { get; set; }
        public decimal? CloseCashDebitTotalBalance { get; set; }
        public decimal? OpenCashCreditTotalBalance { get; set; }
        public decimal? CloseCashCreditTotalBalance { get; set; }
        public decimal? OpenTransferDebitTotalBalance { get; set; }
        public decimal? CloseTransferDebitTotalBalance { get; set; }
        public decimal? OpenTransferCreditTotalBalance { get; set; }
        public decimal? CloseTransferCreditTotalBalance { get; set; }
        public DateTime? UpdatedMonthOfYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsUploaded { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
