using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbAccountType
    {
        public int AccountTypePkid { get; set; }
        public string AccountTypeId { get; set; }
        public string AccountType { get; set; }
    }
}
