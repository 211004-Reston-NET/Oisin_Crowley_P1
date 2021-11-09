using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;


namespace SupplyShopBL
{
    public class StoreFrontBL : IStoreFrontBL
    {
        /// <summary>
        /// repository init to _repo 
        /// </summary>
        private IRepository _repo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_repo">param of p_repo from _repo</param>
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public StoreFront AddStoreFront(StoreFront p_store)
        {
            return _repo.AddStoreFront(p_store);
        }

        public List<StoreFront> GetAllStores()
        {
            List<StoreFront>listAllStoreFront = _repo.GetAllStores();

            return listAllStoreFront;
        }

        public List<Items> GetStoreProducts(StoreFront p_store)
        {
           return _repo.GetStoreProducts(p_store);
        }

        public StoreFront GetStoreByID(int p_id)
        {
           StoreFront storeFound = _repo.GetStoreByID(p_id);

            if (storeFound == null)
            {
                throw new Exception("Store was not found!");
            }
            return storeFound;
        }


    }
}