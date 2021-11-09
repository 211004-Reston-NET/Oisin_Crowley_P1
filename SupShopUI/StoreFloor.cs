using System;
using SupplyShopModels;
using System.Collections.Generic;


namespace SupShopUI
{
    public class StoreFloor : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the store floor");
            Console.WriteLine("Please choose what you want to do");
            Console.WriteLine("See what is in stock [1]");
            Console.WriteLine("Go back to the main menu [2]");
            Console.WriteLine("Exit appliction [0]");
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                //this will return inventory and do something
                    return DirectoryChoice.ShowProduct;
                case "2":
                    return DirectoryChoice.StoreFrontMain;
                case "0":
                    return DirectoryChoice.Exit;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                
                   


            }

            
        }

        
    }
}