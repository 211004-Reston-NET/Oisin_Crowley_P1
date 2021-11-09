using SupplyShop;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface ILineItemBL
    {
        LineItems AddLineItems (LineItems p_lineitem);


         LineItems GetLineItembyID(int p_id);

         
    }

}