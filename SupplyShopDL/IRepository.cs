using System.Collections.Generic;
using System;
using SupplyShopModels;
using SupplyShop;

namespace SupplyShopDL
{
    public interface IRepository
    {
        /// <summary>
        /// it will add a customers in our database
        /// </summary>
        /// <param name="p_cust"> this is the customer we are returning </param>
        /// <returns> it will </returns>
        Customers AddCustomer(Customers p_cust);

        List<Customers> GetAllCustomers();


        Items AddItems(Items p_items);

        List<Items> GetAllItems();

        List<StoreFront> GetAllStores();

        StoreFront AddStoreFront(StoreFront p_stores);

        Items GetProductbyID(int p_id);

        

        StoreFront GetStoreByID(int p_id);

        LineItems AddLineItems(LineItems p_lineitem);

         List<Orders> GetAllOrders();

         List<Items> GetStoreProducts(StoreFront p_store);

          Orders AddOrder(Orders p_orders);

          LineItems GetLineItembyID(int p_id);

          Customers GetCustomerbyID(int p_id);
        /// <summary>
        /// Updating inventory 
        /// </summary>
        /// <param name="p_item"></param>
        /// <returns></returns>
           Items UpdateInventory(Items p_it);
    }
}