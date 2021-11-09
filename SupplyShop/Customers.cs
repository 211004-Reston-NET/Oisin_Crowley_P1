using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace SupplyShopModels
{
    public partial class Customers
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
        public string CustPhone { get; set; }

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
        
    
