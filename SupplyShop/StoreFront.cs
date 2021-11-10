using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SupplyShopModels
{
    public class StoreFront
    {
        private int _storeID;
        public int StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }
        
        private string _storename;
        public string StoreName
        {
            get { return _storename; }
            set { _storename = value; }
        }
        

      private string _streetAdd;
      public string StreetAdd
      {
          get { return _streetAdd; }
          set { _streetAdd = value; }
      }
      
        

        private string _city;
        public string City
        {
            get { return _city; }
            set { 
                        //Regex expression to only hold letters 
                   if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                
                
                
                
                
                _city = value; }
        }
        

        public string State { get; set; }

        private int _zip;
        public int Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        

        private int _productID;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        

        

        


        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Items> Items { get; set; }

             public override string ToString()
        {
            string Stores = $@"Store ID: {StoreID}
Store Name: {StoreName}
Street Address: {StreetAdd}
City: {City}
State: {State}
Zip: {Zip}";
            return Stores;     
            
            }
    }
}