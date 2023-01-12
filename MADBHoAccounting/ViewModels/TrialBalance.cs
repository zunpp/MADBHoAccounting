using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.ViewModels
{
    public class TrialBalance
    {
        [Key]
        public int AccountPkid { get; set; }
        public string AccountMainTitleCode { get; set; }
        public string MainHead { get; set; }        
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string SubsiHead { get; set; }
        public decimal? DuringMonth { get; set; }
        public decimal? EndOfMonth { get; set; }

    }
}
