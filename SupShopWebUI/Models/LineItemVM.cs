using SupplyShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class LineItemVM
    {

        public LineItemVM()
        {

        }
        public LineItemVM(LineItems p_lineitems)
        {
            this.LineItemID = p_lineitems.LineItemID;
            this.OrdersID = p_lineitems.OrdersID;
            this.ProductID = p_lineitems.ProductID;
            this.Quantity = p_lineitems.Quantity;
        }
        public int LineItemID { get; set; }

        public int OrdersID { get; set; }

        public int Quantity { get; set; }

        public int ProductID { get; set; }
    }
}
