using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Models
{
    public class ItemsVM
    {

        public ItemsVM()
        {

        }

        public ItemsVM(Items p_items)
        {
            this.ProductID = p_items.ProductID;
            this.itemName = p_items.itemName;
            this.itemPrice = p_items.itemPrice;
            this.itemQuanity = p_items.itemQuanity;
            this.itemDesc = p_items.ItemDesc;
            this.Category = p_items.Category;
            this.StoreID = p_items.StoreID;

        }
        public int ProductID { get; set; }

        public string itemName { get; set; }

        public int itemQuanity { get; set; }

        public string itemDesc { get; set; }

        public string Category { get; set; }

        public double itemPrice { get; set; }

        public int StoreID { get; set; }
    }
}
