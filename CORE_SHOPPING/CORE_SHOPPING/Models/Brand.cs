using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Product = new HashSet<Product>();
        }

        public int BrandNum { get; set; }
        public string BrandName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
