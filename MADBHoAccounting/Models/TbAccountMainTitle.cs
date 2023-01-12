using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbAccountMainTitle
    {
        public int AccountMainTitlePkid { get; set; }
        public string AccountMainTitleCode { get; set; }
        public string AccountMainTitleInEnglish { get; set; }
        public string AccountMainTitleInMyanmar { get; set; }
        public bool? AccountNatural { get; set; }
        public string TownshipId { get; set; }
        public string StateDivisionId { get; set; }
        public bool? IsUsable { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsUploaded { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
