using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.ViewModels
{
    public class TB_AccountName
    {
        [Key]
        public int AccountID { get; set; }

        [StringLength(10)]
        public string AccountCode { get; set; }

        [StringLength(250)]
        public string SubsiHeadName { get; set; }

        [StringLength(250)]
        public string MainHeadName { get; set; }

        [StringLength(10)]
        public string AccountNature { get; set; }

        [StringLength(5)]
        public string OrderCode { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
