using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class Customer
    {
        public int CstNum { get; set; }
        public string CstAddress { get; set; }
        public string CstEmail { get; set; }
        public string CstGrade { get; set; }
        public string CstId { get; set; }
        public string CstName { get; set; }
        public string CstPhone { get; set; }
        public string CstPwd { get; set; }
        public string CstReserve { get; set; }
        public int? CstUsed { get; set; }
    }
}
