using System;
using SupplyShop;

using SupplyShopDL;

namespace SupplyShopBL
{
    public class LineItemBL : ILineItemBL
    {
         private IRepository _repo;

                //passing the  repo object p_repo
            public LineItemBL(IRepository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }
        public LineItems AddLineItems(LineItems p_lineitem)
        {
            return _repo.AddLineItems(p_lineitem);
        }

        public LineItems GetLineItembyID(int p_id)
        {
            LineItems itemsFound = _repo.GetLineItembyID(p_id);

            if (itemsFound == null)
            {
                throw new Exception("LineItem was not found in inventory!");
            }
            return itemsFound;

        }

        
    }
}