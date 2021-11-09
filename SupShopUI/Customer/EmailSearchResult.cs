using SupplyShopBL;
using SupplyShopModels;
using System.Collections.Generic;
using System;


namespace SupShopUI
{
    public class EmailSearchResult : IStoreFront
    {

         
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public EmailSearchResult(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }  
        public void Display()
        {
            List<Customers>listOfCust = _custBL.GetCustomerEmail(SearchCustomer._findcust.CustEmail);

            if (listOfCust.Count == 0)
            {
                Console.WriteLine("There is no result. Search Again.");
            }
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