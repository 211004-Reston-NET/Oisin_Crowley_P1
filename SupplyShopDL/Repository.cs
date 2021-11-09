using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SupplyShopModels;

namespace  SupplyShopDL
{
    public class Repository
    {
        private const string _filepath ="./../SupplyShopDL/Database/";
        

        private string _jsonString;

        public Customers AddCustomer(Customers p_cust)
        {
            List<Customers> listOfCustomer = GetAllCustomers();

            listOfCustomer.Add(p_cust);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});


            File.WriteAllText(_filepath + "Customers.json",_jsonString);

            return p_cust;
        }
 public List<Customers> GetAllCustomers()
        {
                //  going to read all the customers.json file and conver it to a string to be interp
            _jsonString = File.ReadAllText(_filepath + "Customers.json");


            //we are converting from a string to an object 
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);


        }
            //This is going to add store front
            // parameter being fed in is p_store
        public StoreFront AddStoreFront(StoreFront p_store)
        {
                List<StoreFront> listofStores = GetStoreFronts();

                listofStores.Add (p_store);

             _jsonString = JsonSerializer.Serialize(listofStores, new JsonSerializerOptions{WriteIndented = true});

             File.WriteAllText(_filepath + "StoreFront.json",_jsonString);

             return p_store;
        }
        
        //getting all store fronts        
        public List<StoreFront> GetStoreFronts()
        {
            _jsonString = File.ReadAllText(_filepath + "StoreFront.json");

            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

            // add Items
        public Items AddItems(Items p_items)
        {
                List<Items> listofItems = GetAllItems();

                listofItems.Add (p_items);

             _jsonString = JsonSerializer.Serialize(listofItems, new JsonSerializerOptions{WriteIndented = true});

             File.WriteAllText(_filepath + "Items.json",_jsonString);

             return p_items;
        }
        
        //getting all Items        
        public List<Items> GetAllItems()
        {
            _jsonString = File.ReadAllText(_filepath + "Items.json");

            return JsonSerializer.Deserialize<List<Items>>(_jsonString);
        }

         public Orders AddOrders(Orders p_orders)
        {
                List<Orders> listofOrders = GetAllOrders();

                listofOrders.Add (p_orders);

             _jsonString = JsonSerializer.Serialize(listofOrders, new JsonSerializerOptions{WriteIndented = true});

             File.WriteAllText(_filepath + "Orders.json",_jsonString);

             return p_orders;
        }
        public List<Orders> GetAllOrders()
        {
            _jsonString = File.ReadAllText(_filepath + "Orders.json");

            return JsonSerializer.Deserialize<List<Orders>>(_jsonString);
        }
    }
}