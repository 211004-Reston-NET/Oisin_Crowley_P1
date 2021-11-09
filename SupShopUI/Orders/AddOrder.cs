using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;
using SupShopUI;

namespace SupShopUI
{
    public class AddOrders : IStoreFront
    {
        
        public static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;


        public AddOrders(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;


        }

         

        

        public void Display()
        {

            Console.WriteLine("Would you like to place an order?");
            Console.WriteLine("[1] to view products");
            Console.WriteLine("[2] Select an item to buy");
            
            Console.WriteLine("[0] to return to store front");



        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                return DirectoryChoice.ShowProduct;
                
            
            
            
                
                
                case "2":
                    Console.WriteLine("Enter the ID of the item you want to buy");
                    try
                    {
                        // _finditem.itemId = int.Parse(Console.ReadLine());

                        
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid number only");
                        Console.ReadLine();
                        return DirectoryChoice.AddOrder;
                    }
                    
                    return DirectoryChoice.InitiateOrder;
                   
                   
                    
                    
                    
                    
              
                    
                case "0":
                    return DirectoryChoice.StoreFrontMain;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.StoreFrontMain;




            }
        }






    }
}