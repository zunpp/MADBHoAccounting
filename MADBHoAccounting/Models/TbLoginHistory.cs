using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbLoginHistory
    {
        public int LogInHistoryPkid { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Status { get; set; }
        public string Pcname { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
