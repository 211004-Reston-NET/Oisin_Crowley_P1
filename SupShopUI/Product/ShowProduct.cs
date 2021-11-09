using System;
using SupplyShopBL;
using System.Collections.Generic;
using SupplyShopModels;

namespace SupShopUI
{
    public class ShowProduct : IStoreFront
    {
        private IItemsBL _itemsBL;

        public ShowProduct(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;
        }
        public void Display()

        {  
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
             Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("Product List");
            List<Items>listOfItems = _itemsBL.GetAllItems();

            foreach (Items items in listOfItems)
            {
                Console.WriteLine("================");
                Console.WriteLine(items);
                Console.WriteLine("==============");
            }

            Console.WriteLine("[1] To initiate an order.");
            Console.WriteLine("[0] Go Back");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {

                case "1":
                    return DirectoryChoice.AddOrder;
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