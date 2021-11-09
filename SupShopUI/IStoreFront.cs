namespace SupShopUI
{
    public enum DirectoryChoice
    {
       

       //showing store location choices
       ShowStoreFront,
       StoreSelect,
        StoreFloor,

        ShowStore,
        //close application
        Exit,

        //product and inventory
        MainInventory,
        
       ProdSearchResult,
       ProductSearch,
        ShowProduct,
        ProductPage,

        UpdateProd,


        //customer choices 
        SearchResult,
         NewCustomer,
        SearchCustomer,
        ShowCustomers,
        CustomerPage,

        EmailSearchResult,

        //orders
        AddOrder,
        AddLineItem,

        CollectOrder,

        InitiateOrder,

        //initial page
        StoreFrontMain
    }

    public interface IStoreFront
    {
        //will display inventory of the Store

        void Display();

        /// will be user choice

        DirectoryChoice YourChoice();
    }
}