using System;
using SupplyShopBL;
using System.Collections.Generic;
using SupplyShopModels;

namespace SupShopUI
{
    public class ShowStoreFront : IStoreFront
    {
        private IStoreFrontBL _storeBL;

        public ShowStoreFront(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Display()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("Store  List");
            List<StoreFront>listOfStores = _storeBL.GetAllStores();

            foreach (StoreFront store in listOfStores)
            {
                Console.WriteLine("================");
                Console.WriteLine(store);
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