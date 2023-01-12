using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbAccountName
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string SubsiHeadName { get; set; }
        public string MainHeadName { get; set; }
        public string AccountNature { get; set; }
        public string OrderCode { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
