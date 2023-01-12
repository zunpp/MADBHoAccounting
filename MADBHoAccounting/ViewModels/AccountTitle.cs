using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Models
{
    public class AccountTitle
    {
        [Key]
        public int AccountSubItemPkid { get; set; }
        public string AccountMainTitleCode { get; set; }
        public string AccountMainTitleInEnglish { get; set; }
        public string AccountSubTitleCode { get; set; }
        public string AccountSubTitleInEnglish { get; set; }
        //public string AccountMainTitleInMyanmar { get; set; }
        public string AccountSubTitleInMyanmar { get; set; }
        //public decimal? DebitAmount { get; set; }
        //public decimal? CreditAmount { get; set; }
        //public string AccountNature { get; set; }
        //public string Description { get; set; }
        //public string TownshipId { get; set; }
        //public string StateDivisionId { get; set; }
        //public bool? MainTitleDeleted { get; set; }
        //public bool? SubTitleDeleted { get; set; }
        //public bool? MainIsUploaded { get; set; }
        //public bool? SubTitleUploaded { get; set; }
        //public bool? IsUsable { get; set; }
        //public int? CreatedBy { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public string CreatedDate { get; set; } = DateTime.Now.ToShortDateString();
    }
}
