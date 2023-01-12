using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class VwIncomeProgressive
    {
        public string DivisionCode { get; set; }
        public string DiviSionName { get; set; }
        public string TownOrderCode { get; set; }
        public string TownName { get; set; }
        public decimal IntSlc { get; set; }
        public decimal IntStl { get; set; }
        public decimal IntLtl { get; set; }
        public decimal IntOverdraft { get; set; }
        public decimal IntLsl { get; set; }
        public decimal IntLtrs { get; set; }
        public decimal IntLrsLtlJica { get; set; }
        public decimal IntLrsStlJica { get; set; }
        public decimal IntMebLtl { get; set; }
        public decimal IntMebStl { get; set; }
        public decimal PenIntSlc { get; set; }
        public decimal PenIntSt { get; set; }
        public decimal PenIntLt { get; set; }
        public decimal PenIntLs { get; set; }
        public decimal PenIntLtrs { get; set; }
        public decimal PenIntLrsLtlJica { get; set; }
        public decimal PenIntLrsStlJica { get; set; }
        public decimal PenIntLrsLtlMeb { get; set; }
        public decimal PenIntLrsStlMeb { get; set; }
        public decimal Misc { get; set; }
        public decimal FeeAndCommission { get; set; }
        public decimal IntCovid19 { get; set; }
        public decimal PenIntCovid19 { get; set; }
    }
}
