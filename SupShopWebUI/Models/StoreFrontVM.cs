using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class StoreFrontVM
    {
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

        public string StoreName { get; set; }

        public string City { get; set; }

        public string StreetAdd { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }
    }
}
