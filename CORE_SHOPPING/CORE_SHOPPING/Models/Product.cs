using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderHasPdt = new HashSet<OrderHasPdt>();
            ProductDetail = new HashSet<ProductDetail>();
        }

        public int PdtNum { get; set; }
        public int PdtBrand { get; set; }
        public string PdtName { get; set; }
        public int PdtPrice { get; set; }
        public int? PdtSale { get; set; }
        public string PdtType { get; set; }
        public int? PdtUsed { get; set; }

        public Brand PdtBrandNavigation { get; set; }
        public ICollection<OrderHasPdt> OrderHasPdt { get; set; }
        public ICollection<ProductDetail> ProductDetail { get; set; }
    }
}
