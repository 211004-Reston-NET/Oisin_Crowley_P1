using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class CustomerVM

    {
        public CustomerVM(List<Customers> customers)
        {

        }

        public CustomerVM(Customers p_cust)
        {
            this.CustomerId = p_cust.CustomerId;
            this.CustomerName = p_cust.CustomerName;
            this.CustCity = p_cust.CustCity;
            this.CustState = p_cust.CustState;
            this.CustStreetAdd = p_cust.CustStreetAdd;
            this.CustZip = p_cust.CustZip;
            this.CustPhone = p_cust.CustPhone;
            this.CustEmail = p_cust.CustEmail;
  
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustStreetAdd { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public int CustZip { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
    }
}
