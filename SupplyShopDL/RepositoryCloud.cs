using System.Collections.Generic;
using SupplyShopModels;

using System.Linq;

using SupplyShop;
using Microsoft.EntityFrameworkCore;


namespace SupplyShopDL
{
    public class RepositoryCloud : IRepository
    {
       private SupplyShopDatabaseContext _context;

       public RepositoryCloud(SupplyShopDatabaseContext p_context)
        {
            _context = p_context;
        }
        public Customers AddCustomer(Customers p_cust)
        {
               _context.Customers.Add(p_cust);
                
                
                _context.SaveChanges();

                return p_cust;
            
        }

        public Items AddItems(Items p_items)
        {
            _context.Items.Add(p_items);
            
            _context.SaveChanges();

            return p_items;
        }

        public LineItems AddLineItems(LineItems p_lineitem)
        {
            _context.LineItems.Add(p_lineitem);
            
            _context.SaveChanges();

            return p_lineitem;
        }

        public Orders AddOrder(Orders p_orders)
        {
            _context.Orders.Add(p_orders);
            _context.SaveChanges();

            return p_orders;
        }

       

        public StoreFront AddStoreFront(StoreFront p_stores)
        {
           _context.StoreFronts.Add
           (p_stores);
           _context.SaveChanges();

           return p_stores;
        }

        public List<Customers> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public List<Items> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public List<StoreFront> GetAllStores()
        {
            return _context.StoreFronts.ToList();
        }

        public Items GetProductbyID(int p_id)
        {
            return _context.Items.Find(p_id);
                
            
        }

         public Customers GetCustomerbyID(int p_id)
        {
           return _context.Customers.AsNoTracking().FirstOrDefault(cust => cust.CustomerId == p_id);
        }

        public List<Customers> SearchFunction(string searchString)
        {
            var customer = from cust in _context.Customers
                           select cust;

            if (!string.IsNullOrEmpty(searchString))
            {
                customer = customer.Where(cu => cu.CustomerName!.Contains(searchString));
            }

            return customer.ToList();
        }


         public LineItems GetLineItembyID(int p_id)
        {
            return _context.LineItems.Find(p_id);
        }
        /// <summary>
        /// This will give specific store based on the ID 
        /// </summary>
        /// <param name="p_id">this is the id it will look for </param>
        /// <returns>returns the store it has found </returns>
        public StoreFront GetStoreByID(int p_id)
        {
            return _context.StoreFronts.Find(p_id);
        }

        public List<Items> GetStoreProducts(int p_id)
        {

            //Query Santax 
            return _context.Items
            .Where(it => it.StoreID == p_id).ToList();
            
            


                    
        }

        /// <summary>
        /// Updating inventory 
        /// </summary>
        /// <param name="p_item"></param>
        /// <returns></returns>
          public Items UpdateInventory(Items p_it)
          {
                
               
                _context.Items.Update(p_it);

                _context.SaveChanges();

                return p_it;
          }

        public Items DeleteItems(Items p_it)
        {
            _context.Items.Remove(p_it);
            _context.SaveChanges();
            return p_it;
        }


        public StoreFront DeleteStore(StoreFront p_store)
        {
            _context.StoreFronts.Remove(p_store);
            _context.SaveChanges();
            return p_store;
        }

        public Customers DeleteCust(Customers p_cust)
        {
            _context.Customers.Remove(p_cust);
            _context.SaveChanges();
            return p_cust;
        }

        //   public Model.Orders PlaceOrder(LineItems p_lineitems, Model.Orders p_Orders)
        //   {

        //   }


    }
}