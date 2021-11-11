using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class StoreFrontVM
    {

        public StoreFrontVM()
        {

        }
        public StoreFrontVM(StoreFront p_store)
        {
            this.StoreID = p_store.StoreID;
            this.StoreName = p_store.StoreName;
            this.StreetAdd = p_store.StreetAdd;
            this.City = p_store.City;
            this.State = p_store.State;
            this.Zip = p_store.Zip;

        }

        public int StoreID { get; set; }

        [Required]
        public string StoreName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string StreetAdd { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }
    }
}
