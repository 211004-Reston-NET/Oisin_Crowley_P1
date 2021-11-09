using SupplyShopBL;
using SupplyShopModels;
using System.Collections.Generic;
using System;


namespace SupShopUI
{
    public class SearchResult : IStoreFront
    {

         
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public SearchResult(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }  
        public void Display()
        {
            List<Customers>listOfCust = _custBL.GetCustomers(SearchCustomer._findcust.CustomerName);
            foreach (Customers cust in listOfCust)
            {
                Console.WriteLine("==============");
                Console.WriteLine(cust);
                Console.WriteLine("===============");
            }
            Console.WriteLine("[0] Go Back");
        }

        public DirectoryChoice YourChoice()
        {
           string userChoice = Console.ReadLine();

           switch(userChoice)
           {
               case "0":
               return DirectoryChoice.SearchCustomer;
               default:
               Console.WriteLine("Please enter a valid response");
               Console.WriteLine("Press enter to continue");
               Console.ReadLine();
               return DirectoryChoice.SearchResult;
           }
        }
    }
}