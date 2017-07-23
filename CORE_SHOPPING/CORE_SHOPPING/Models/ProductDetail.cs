using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class ProductDetail
    {
        public int PdtNum { get; set; }
        public string PdtSize { get; set; }
        public int? PdtAmount { get; set; }

        public Product PdtNumNavigation { get; set; }
    }
}
