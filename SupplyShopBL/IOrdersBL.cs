using System.Collections.Generic;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface IOrdersBL 
    {
        List<Orders> GetAllOrders();

         Orders AddOrder(Orders p_orders);

        
    }
}