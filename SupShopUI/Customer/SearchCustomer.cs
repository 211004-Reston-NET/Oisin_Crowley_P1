using SupShopUI;
using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;

namespace SupShopUI
{
    public class SearchCustomer : IStoreFront
    {
        public static Customers _findcust = new Customers();
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public SearchCustomer(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }  
        
        public void Display()
        {
          Console.WriteLine("[1] To enter the name of the customer you want to search for.");
          Console.WriteLine("[2] To Search a customer by Email.");
            Console.WriteLine("[0] To go back. ");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                try
                {
                     Console.WriteLine("Enter the name of the customer you want to find");
                    _findcust.CustomerName = Console.ReadLine();
                    return DirectoryChoice.SearchResult;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("No result found");
                    Console.WriteLine("Press [0] to go back");
                    Console.ReadLine();
                    return DirectoryChoice.SearchCustomer;
                }
                case "2":
                    Console.WriteLine("Enter the email you want to search for.");
                    _findcust.CustEmail = Console.ReadLine();
                    return DirectoryChoice.EmailSearchResult;
                    
                
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.SearchCustomer;
            }
        }
    }
}