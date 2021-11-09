using System;
using SupplyShopModels;
using SupplyShopBL;

namespace SupShopUI
{
    public class MainInventory : IStoreFront
    {
     
   private static Items _items = new Items();
        private IItemsBL _itemsBL;


        public MainInventory(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;


        } 

        public void Display()
        {
            Console.WriteLine("Add products to the inventory.");
            
            Console.WriteLine("[1] Please enter the product name.");
            Console.WriteLine("[2] Please enter the products price.");
            Console.WriteLine("[3] Please enter the product quantity.");
            Console.WriteLine("[4] to add item category.");
            Console.WriteLine("[5] To add product description.");
            Console.WriteLine("[6] Add store ID");
            Console.WriteLine("[7] Save Item");
            
            Console.WriteLine("Product Name: " + _items.itemName);
            Console.WriteLine("Product Price: " + _items.itemPrice);
            Console.WriteLine("Product Quantity: " + _items.itemQuanity);
            Console.WriteLine("Item Category: " + _items.Category);
            Console.WriteLine("Item Description: " + _items.ItemDesc);
            Console.WriteLine("Store ID: " + _items.StoreID);

            
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                

                case "1":
                    try
                    {
                        _items.itemName = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                    }
                    return DirectoryChoice.MainInventory;
                case "2":
                             try
                    {
                      _items.itemPrice = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid Number");
                    }
                    try
                    {
                        _itemsBL.AddItems(_items);
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                        
                    }
                    return DirectoryChoice.MainInventory;
                    case "3":
                             try
                    {
                      _items.itemQuanity = int.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid Number");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                    }
                 
                    return DirectoryChoice.MainInventory;
                    case "4":
                        Console.WriteLine("Enter item category.");
                        _items.Category = Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                    case "5":
                        Console.WriteLine("Enter item description");
                        _items.ItemDesc = Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                    case "6":
                        try
                        {
                             Console.WriteLine("Enter store ID");
                             _items.StoreID = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            
                        Console.WriteLine("Please enter a valid Number");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                        }
                        return DirectoryChoice.MainInventory;


                    /// <summary>
                    /// Adds items/products to the database.  
                    /// </summary>
                    /// <returns></returns>
                    case "7":
                    _itemsBL.AddItems(_items);
                    return DirectoryChoice.MainInventory;
                    
                case "0":
                    return DirectoryChoice.StoreFrontMain;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                
                   


            }
        }
    }
}