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

         List<Items> GetStoreProducts(int p_id);

          Orders AddOrder(Orders p_orders);

          LineItems GetLineItembyID(int p_id);

          Customers GetCustomerbyID(int p_id);
        /// <summary>
        /// Updating inventory 
        /// </summary>
        /// <param name="p_item"></param>
        /// <returns></returns>
           Items UpdateInventory(Items p_it);

        Items DeleteItems(Items p_it);

        List<Customers> SearchFunction(string searchString);
        /// <summary>
        /// Deletes a store front from the store list
        /// </summary>
        /// <param name="p_store">this is a store that is being passed</param>
        /// <returns></returns>
         StoreFront DeleteStore(StoreFront p_store);

        Customers DeleteCust(Customers p_cust);
    }
}