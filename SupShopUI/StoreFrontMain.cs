using System;

namespace SupShopUI
{
    public class StoreFrontMain : IStoreFront
    {
      

        public void Display()
        {
            Console.WriteLine("Welcome to the Supply Store");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] Products Information. ");
            Console.WriteLine("[2] Customer Information.");
            Console.WriteLine("[3] Store Information");
            Console.WriteLine("[4] Order Placement" );
            Console.WriteLine("[0] - Exit the Store");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                return DirectoryChoice.ProductPage;

                case "2":
                return DirectoryChoice.CustomerPage;
                case "3":
                return DirectoryChoice.ShowStoreFront;
                case "4":
                return DirectoryChoice.InitiateOrder;
                
                case "0":
                return DirectoryChoice.Exit;
                default:
                Console.WriteLine   ("Please enter a valid response");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                return DirectoryChoice.StoreFrontMain;
            }

        }
    }
}
