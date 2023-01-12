using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwFinancialYear
    {
        public int FinancialYearPkid { get; set; }
        public DateTime? FinancialStartDate { get; set; }
        public DateTime? FinancialMiddleDate { get; set; }
        public DateTime? FinancialEndDate { get; set; }
        public string FinancialYear { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsUploaded { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
