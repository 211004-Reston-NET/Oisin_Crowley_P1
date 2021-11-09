using System;
using SupplyShop;
using SupplyShopBL;

namespace SupShopUI
{
    public class AddLineItem : IStoreFront
    {
        public static LineItems _lineitem = new LineItems();
        private ILineItemBL _lineitemBL;


        public AddLineItem(ILineItemBL p_lineitemBL)
        {
            _lineitemBL = p_lineitemBL;


        }
        public void Display()
        {
           _lineitem = new LineItems();
            Console.WriteLine("Line Item Order");
            Console.WriteLine("Product Quantity:" +  _lineitem.Quantity);
           Console.WriteLine("Product Id: " + _lineitem.ProductID);
           Console.WriteLine("Order Id: " + InitiateOrder._orders.OrderID);
            Console.WriteLine("Enter your quantity of Order");
            try
                    {
                         _lineitem.Quantity = int.Parse(Console.ReadLine());
                         
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please Enter valid numbers");
                        
                    }
            Console.WriteLine("[2] Save Selection");
            
            
                    

            
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                /// <summary>
                /// gathering input for line items
                /// </summary>
                /// <returns></returns>
                case "1":

                    // Console.WriteLine("Enter Amount you want to purchase");
                    // try
                    // {
                    //      _lineitem.Quantity = int.Parse(Console.ReadLine());
                    //      return DirectoryChoice.AddLineItem;
                    // }
                    // catch (System.Exception)
                    // {
                        
                    //     Console.WriteLine("Please Enter valid numbers");
                    //     return DirectoryChoice.AddLineItem;
                    // }
                 
                 case "2":
               // _lineitem.ProductID = AddOrders._finditem.itemId;
                


                _lineitemBL.AddLineItems(_lineitem);
                
                    Console.WriteLine("Information Added!");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    return DirectoryChoice.CollectOrder;
                    

                case "3":
                    return DirectoryChoice.CollectOrder;


                case "0":
                    return DirectoryChoice.StoreFrontMain;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.StoreFrontMain;
        }
    }
}}