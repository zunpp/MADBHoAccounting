using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.ViewModels
{
    public class TB_FinancialYear
    {
        [Key]
        public int FinancialYearPkid { get; set; }
        public string FinancialStartDate { get; set; }
        public string FinancialMiddleDate { get; set; }
        public string FinancialEndDate { get; set; }
        public String FinancialYear { get; set; }
        public bool? IsActiveFinancialYear { get; set; }
        public bool? IsAccountClosed { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsUploaded { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
