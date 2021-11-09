using System;
using System.Collections.Generic;
using SupplyShop;

namespace SupplyShopModels
{
    public class Orders
    {

 
        //fields for Order information 
        private int _orderID;
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        
      
        
        

        
        public double totalPrice { get; set; } 

        private int _storeid;
        public int StoreId
        {
            get { return _storeid; }
            set { _storeid = value; }
        }

        

        
        private int _customerid;
        public int CustomerID
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        
        
        public virtual Customers Customer { get; set; }
        public virtual StoreFront Store { get; set; }
        public virtual ICollection<LineItems> LineItems { get; set; }
           
        
        

        
    }
}