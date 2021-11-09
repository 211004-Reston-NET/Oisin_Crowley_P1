using System;



namespace SupShopUI
{
    public class CustomerPage : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Enter new customer [1]");
            Console.WriteLine("Search for a customer [2]");
            
            Console.WriteLine("Go back [0]");
        }

        public DirectoryChoice YourChoice()
        {
           string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                   return DirectoryChoice.NewCustomer;
                case "2":
                    return DirectoryChoice.SearchCustomer;
               
                
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.SearchCustomer;
        }
    }
}}