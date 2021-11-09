using System;
using SupplyShopBL;
using SupplyShopDL;


namespace SupShopUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            IMenuFactory factory = new MenuFactory();

            IStoreFront page = factory.GetMenu(DirectoryChoice.StoreFrontMain);

            while (repeat)
            {
                //This will clear the termanel
                Console.Clear();

                page.Display();
                DirectoryChoice currentPage = page.YourChoice();

                if (currentPage == DirectoryChoice.Exit)
                 {
                     Console.WriteLine("You are exiting the application!");
                     Console.WriteLine("Press enter to continue");
                     Console.ReadLine();
                     repeat = false;
                 }
                 else
                 {
                     page = factory.GetMenu(currentPage);
                 }







            }








        }
    }
}








