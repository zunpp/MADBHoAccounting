﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwLoanReturnTransPeopleGroupByRegion
    {
        public string TownshipId { get; set; }
        public string RegionId { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string TotalPeople { get; set; }
        public string DebtPeople { get; set; }
        public string PeoplePercentage { get; set; }
        public string DebtPeoplePercentage { get; set; }
    }
}
