using SupplyShopModels;
using SupplyShop;

namespace SupShopUI
{
    public class SingletonFields
    {
        public static Orders _orders = new Orders();

        public static LineItems _lineitems = new LineItems();
    }
}