using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class OrderHasPdt
    {
        public int PdtNum { get; set; }
        public int OrderNum { get; set; }
        public string PdtSize { get; set; }
        public string OrderState { get; set; }
        public int? PdtAmount { get; set; }

        public Order OrderNumNavigation { get; set; }
        public Product PdtNumNavigation { get; set; }
    }
}
