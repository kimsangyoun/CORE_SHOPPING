using System;
using System.Collections.Generic;

namespace CORE_SHOPPING.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderHasPdt = new HashSet<OrderHasPdt>();
        }

        public int OrderNum { get; set; }
        public int? CstNum { get; set; }
        public int? OrderDpsTf { get; set; }
        public int? OrderPrice { get; set; }
        public string OrderType { get; set; }

        public ICollection<OrderHasPdt> OrderHasPdt { get; set; }
    }
}
