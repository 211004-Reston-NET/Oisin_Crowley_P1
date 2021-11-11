using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class OrdersVM
    {

        public OrdersVM()
        {

        }
        public OrdersVM(Orders p_orders)
        {
            this.OrderID = p_orders.OrderID;
            this.StoreID = p_orders.StoreId;
            this.TotalPrice = p_orders.totalPrice;
            this.CustomerID = p_orders.CustomerID;
        }
        public int OrderID { get; set; }

        public double TotalPrice { get; set; }

        public int StoreID { get; set; }

        public int CustomerID { get; set; }
    }
}
