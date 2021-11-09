using SupplyShopBL;
using SupplyShopModels;
using System.Collections.Generic;
using System;


namespace SupShopUI
{
    public class ProdSearchResult : IStoreFront
    {

         
        private static Items _items = new Items();
        private IItemsBL _itemsBL;


        public ProdSearchResult(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;


        }  
        public void Display()
        {
            List<Items>listOfItems = _itemsBL.GetItems(ProductSearch._finditem.itemName);
            foreach (Items items in listOfItems)
            {
                Console.WriteLine("==============");
                Console.WriteLine(items);
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
               return DirectoryChoice.ProductSearch;
               default:
               Console.WriteLine("Please enter a valid response");
               Console.WriteLine("Press enter to continue");
               Console.ReadLine();
               return DirectoryChoice.SearchResult;
           }
        }
    }
}