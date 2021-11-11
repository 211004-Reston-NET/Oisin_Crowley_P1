using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace SupplyShopModels
{
    public class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustStreetAdd { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public int CustZip { get; set; }
        public string CustEmail { get; set; }

        private string _custphone;

        public string CustPhone
        {
            get { return _custphone; }
            set {

                //Regex expression to only hold letters 
                if (!Regex.IsMatch(value, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Please Enter a valid Phone number");
                }




                _custphone = value; }
        }



        public virtual ICollection<Orders> Orders { get; set; }
   


        

          public override string ToString()
        {
            string cust = $@"Name: {CustomerName}
Street Address: {CustStreetAdd}
City: {CustCity}
State: {CustState}
Email : {CustEmail}
Phone : {CustPhone}";
            return cust;     
            
            }
 }}
        
    
