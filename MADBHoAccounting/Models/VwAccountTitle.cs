using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwAccountTitle
    {
        public int AccountMainTitlePkid { get; set; }
        public string AccountMainTitleCode { get; set; }
        public int AccountSubItemPkid { get; set; }
        public string AccountSubTitleCode { get; set; }
        public string AccountMainTitleInEnglish { get; set; }
        public string AccountSubTitleInEnglish { get; set; }
        public string AccountMainTitleInMyanmar { get; set; }
        public string AccountSubTitleInMyanmar { get; set; }
        public string AccountNatural { get; set; }
        public string TownshipId { get; set; }
        public string StateDivisionId { get; set; }
        public bool? IsUsable { get; set; }
        public bool? MainTitleDeleted { get; set; }
        public bool? MainIsUploaded { get; set; }
        public bool? SubTitleDeleted { get; set; }
        public bool? SubTitleUploaded { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
