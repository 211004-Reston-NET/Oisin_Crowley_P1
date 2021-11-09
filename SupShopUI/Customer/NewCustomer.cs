using System;
using SupplyShopModels;
using SupplyShopBL;

namespace SupShopUI
{
    public class NewCustomer : IStoreFront
    {
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public NewCustomer(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }

        public void Display()
        {

            Console.WriteLine("Adding a new customer");
            Console.WriteLine("Name " + _cust.CustomerName);
            Console.WriteLine("Street Address: " + _cust.CustStreetAdd);
            Console.WriteLine("City " + _cust.CustCity);
            Console.WriteLine("State " + _cust.CustState);
            Console.WriteLine("Zip: " + _cust.CustZip);
            Console.WriteLine("Phone " + _cust.CustPhone);
            Console.WriteLine("Email " + _cust.CustEmail);
    
            Console.WriteLine("[1] to enter the Name.");
            Console.WriteLine("[2] Enter street address");
            Console.WriteLine("[3] to enter the City.");
            Console.WriteLine("[4] To enter the State.");
            Console.WriteLine("[5] to enter the zip.");
            Console.WriteLine("[6] to enter the phone number.");
            Console.WriteLine("[7] to enter the email.");
            
            Console.WriteLine("[8] Save Customer.");
            Console.WriteLine("[0] to return to store front");



        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                /// <summary>
                /// gathering input of the new customers
                /// </summary>
                /// <returns></returns>
                case "1":

                    Console.WriteLine("Enter the name");
                    _cust.CustomerName = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "2":
                    Console.WriteLine("Enter Street Address");
                    _cust.CustStreetAdd = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "3":
                    Console.WriteLine("Enter the City");
                    _cust.CustCity = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "4":
                    Console.WriteLine("Enter the State");
                    _cust.CustState = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;

                case "5":
                try
                {
                     Console.WriteLine("Enter the Zip Code");
                    _cust.CustZip = int.Parse(Console.ReadLine());
                    return DirectoryChoice.NewCustomer;
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Please enter valid numbers only!");
                    return DirectoryChoice.NewCustomer;
                }
                    
                case "6":

                try
                {
                     Console.WriteLine("Enter the Phone Number");
                    _cust.CustPhone = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Please enter a valid phone number.");
                    return DirectoryChoice.NewCustomer;
                }
                    
                case "7":
                    Console.WriteLine("Enter the Email");
                    _cust.CustEmail = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "8":
                try
                {   _custBL.AddCustomer(_cust);
                    Console.WriteLine("Information Added");
                    return DirectoryChoice.NewCustomer;
                     
                }
                catch (Exception)
                {
                    
                   Console.WriteLine("You must enter a value into all fields. ");
                   return DirectoryChoice.NewCustomer;
                }
                    
                case "0":
                    return DirectoryChoice.StoreFrontMain;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.StoreFrontMain;




            }
        }







    }
}
