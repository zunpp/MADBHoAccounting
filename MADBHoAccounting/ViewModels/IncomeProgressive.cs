using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.ViewModels
{
    public class IncomeProgressive
    {
        public string DivisionCode {get;set;}
        public string DiviSionName {get;set;}
        public string TownOrderCode {get;set;}
        public string TownName {get;set;}
        public Decimal? Int_SLC {get;set;}
        public Decimal? Int_STL {get;set;}
        public Decimal? Int_LTL {get;set;}
        public Decimal? Int_Overdraft {get;set;}
        public Decimal? Int_LSL {get;set;}
        public Decimal? Int_LTRS {get;set;}
        public Decimal? Int_LRS_LTL_JICA {get;set;}
        public Decimal? Int_LRS_STL_JICA {get;set;}
        public Decimal? Int_MEB_LTL {get;set;}
        public Decimal? Int_MEB_STL {get;set;}
        public Decimal? PenInt_SLC {get;set;}
        public Decimal? PenInt_ST {get;set;}
        public Decimal? PenInt_LT {get;set;}
        public Decimal? PenInt_LS {get;set;}
        public Decimal? PenIntLTRS {get;set;}
        public Decimal? PenInt_LRS_LTL_JICA {get;set;}
        public Decimal? PenInt_LRS_STL_JICA {get;set;}
        public Decimal? PenInt_LRS_LTL_MEB {get;set;}
        public Decimal? PenInt_LRS_STL_MEB {get;set;}
        public Decimal? Misc {get;set;}
        public Decimal? FeeAndCommission {get;set;}
        public Decimal? Int_Covid19 {get;set;}
        public Decimal? PenInt_Covid19 { get;set;}
    }
}
