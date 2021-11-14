using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;
using System.Linq;

namespace SupplyShopBL
{
    public class ItemsBL : IItemsBL
    {

            private IRepository _repo;

                //passing the  repo object p_repo
            public ItemsBL(IRepository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }

            public Items AddItems(Items p_items)
            {
                return _repo.AddItems(p_items);
            }

        public Items DeleteItems(Items p_it)
        {
            return _repo.DeleteItems(p_it);
        }

        public List<Items> GetAllItems()
            {
                List<Items>listOfItems = _repo.GetAllItems();
                for (int i = 0; i< listOfItems.Count; i++)
                {
                    listOfItems[i].itemName = listOfItems[i].itemName.ToUpper();
                }


                return listOfItems;
            }

        public List<Items> GetItems(string p_itemName)
        {
             List<Items>listOfitems = _repo.GetAllItems();

                return listOfitems.Where(items => items.itemName.ToUpper().Contains(p_itemName.ToUpper())).ToList();
        }

        public Items GetProductbyID(int p_id)
        {
            Items itemsFound = _repo.GetProductbyID(p_id);

            if (itemsFound == null)
            {
                throw new Exception("Product was not found in inventory!");
            }
            return itemsFound;
        }

        public Items UpdateInventory(Items p_it, int p_howMuchAdd)
        {
            p_it.itemQuanity += p_howMuchAdd;

            return _repo.UpdateInventory(p_it);
        }
    }
}
