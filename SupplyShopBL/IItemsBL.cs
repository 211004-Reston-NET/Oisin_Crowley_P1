using System.Collections.Generic;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface IItemsBL 
    {
        List<Items> GetAllItems();

        Items AddItems (Items p_items);
        
        List<Items> GetItems(string p_itemName);

        Items GetProductbyID (int p_id);

        Items UpdateInventory(Items p_it, int p_howMuchAdd);

        Items DeleteItems(Items p_it);
    }
}