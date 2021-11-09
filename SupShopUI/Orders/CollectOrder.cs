using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;
using SupShopUI;
using SupplyShop;

namespace SupShopUI
{
    public class CollectOrder : IStoreFront
    {
        
        public static Orders _orders = new Orders();

        

        
        private IOrdersBL _ordersBL;


        public CollectOrder(IOrdersBL p_ordersBL,ILineItemBL p_lineitemBL )
        {
            _ordersBL = p_ordersBL;

            _lineitemBL = p_lineitemBL;


        }

         private ILineItemBL _lineitemBL;


    

        

        public void Display()
        {
             _orders = new Orders();
             

            Console.WriteLine("Would you like to place an order?");

            
            
            Console.WriteLine("Product Quantity " + AddLineItem._lineitem.Quantity);
            Console.WriteLine("Product ID " + AddLineItem._lineitem.ProductID);
            Console.WriteLine("[1] to Enter your customer numer");
            Console.WriteLine("[2] to enter store ID");
            Console.WriteLine("Save Order");




        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                Console.WriteLine("Please Enter your customer number.");
                try
                {
                     _orders.CustomerID = Int32.Parse(Console.ReadLine());
                     
                }
                catch (System.Exception)
                {
                   Console.WriteLine("Please enter a valid number");
                   Console.WriteLine("Press enter to continue");
                   Console.ReadLine();
                   return DirectoryChoice.CollectOrder;
                }
                return DirectoryChoice.CollectOrder;
                case "2":
                    Console.WriteLine("Please enter your Stores ID");
                    try
                    {
                         _orders.StoreId = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid number");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return DirectoryChoice.CollectOrder;
                    }
                    return DirectoryChoice.CollectOrder;
                case "3":
                    
                    _ordersBL.AddOrder(_orders);
                    return DirectoryChoice.AddOrder;
            
            
            
            
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