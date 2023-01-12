using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class TbStateDivision
    {
        public int StateDivisionPkid { get; set; }
        public string StateDivisionCode { get; set; }
        public string StateDivision { get; set; }
    }
}
