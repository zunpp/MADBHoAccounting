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
        public string AccountCode { get; set; }
        public string MainHead { get; set; }        
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string SubsiHead { get; set; }
        public decimal? DuringMonth { get; set; }
        public decimal? EndOfMonth { get; set; }
        public string TownName { get; set; }
        public decimal? Balance { get; set; }

    }
}
