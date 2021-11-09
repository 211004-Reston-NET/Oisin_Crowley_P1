using System;



namespace SupShopUI
{
    public class ProductPage : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Enter inventory [1]");
            
            Console.WriteLine("View All Products [2]");
            Console.WriteLine("Search Products [3]");
            Console.WriteLine("View Store Inventory [4]");
            Console.WriteLine("Update Product Inventory[5]");
            Console.WriteLine("Go back [0]");
        }

        public DirectoryChoice YourChoice()
        {
           string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                   return DirectoryChoice.MainInventory;
                case "2":
                    return DirectoryChoice.ShowProduct;
                case "3":
                    return DirectoryChoice.ProductSearch;
                case "4":
                    return DirectoryChoice.StoreSelect;
                case "5":
                    return DirectoryChoice.UpdateProd;
                
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.SearchCustomer;
        }
    }
}}