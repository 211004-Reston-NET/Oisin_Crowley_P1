using System;
using SupplyShopBL;
using System.Collections.Generic;
using SupplyShopModels;

namespace SupShopUI
{
    public class ShowCustomers : IStoreFront
    {
        private ICustomersBL _custBL;

        public ShowCustomers(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Display()
        {
            Console.WriteLine("Customer List");
            List<Customers>listOfCustomer = _custBL.GetAllCustomers();

            foreach (Customers cust in listOfCustomer)
            {
                Console.WriteLine("================");
                Console.WriteLine(cust);
                Console.WriteLine("==============");
            }
            Console.WriteLine("[0] Go Back");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please input a valid choice");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                return DirectoryChoice.ShowCustomers;
            }
        }
    }
}