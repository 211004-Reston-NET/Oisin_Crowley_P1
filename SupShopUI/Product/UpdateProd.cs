using System;
using SupplyShopBL;
using SupplyShopModels;

namespace SupShopUI
{
    public class UpdateProd : IStoreFront
    {
        private IItemsBL _itemsBL;

        public UpdateProd(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;
        }
        public void Display()
        {
            Console.WriteLine("Update Inventory");
            Console.WriteLine("[1] Select a product by ID");
            Console.WriteLine("[0] To go back.");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                Console.WriteLine("Enter the Item Id of product you want to update.");
                try
                {
                    int prodID = Int32.Parse(Console.ReadLine());
                    Items itemFound = _itemsBL.GetProductbyID(prodID);

                    Console.WriteLine("How much inventory do you want to add?");
                    int addInven = Int32.Parse(Console.ReadLine());
                    _itemsBL.UpdateInventory(itemFound, addInven);


                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Please input number and not a character");
                    return DirectoryChoice.UpdateProd;
                }

                return DirectoryChoice.UpdateProd;
                case "0":
                    return DirectoryChoice.ProductPage;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.ProductPage;
            }
            
        }
    }
}