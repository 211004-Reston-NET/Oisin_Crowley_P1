using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class OrdersVM
    {
        public int OrderID { get; set; }

        public double TotalPrice { get; set; }

        public int StoreID { get; set; }

        public int CustomerID { get; set; }
    }
}
