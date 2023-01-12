using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.ViewModels
{
    public class TB_AccountDetailEntry
    { 
        [Key]
        public int AccountID { get; set; }
        public string Date { get; set; }
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
        public bool IsDeleted { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }

    }
}
