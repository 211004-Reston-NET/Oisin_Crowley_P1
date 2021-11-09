using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SupplyShopBL;
using SupplyShopDL;




namespace SupShopUI
{
    public class MenuFactory : IMenuFactory
    {     
        public IStoreFront GetMenu(DirectoryChoice p_menu)
        {
            var configuration = new ConfigurationBuilder()//Configurationbuilder is the class that came from microsoft.extension.configuration package
                .SetBasePath(Directory.GetCurrentDirectory())//
                .AddJsonFile("appsetting.json")//adds the appsetting.json file in our supshop ui
                .Build(); ///builds our configuration
                 
                
                DbContextOptions<SupplyShopDatabaseContext> options = new DbContextOptionsBuilder<SupplyShopDatabaseContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;
            
            
            
               // creating my directory objects in the factory 
        //parameter is p_menu 
        /// 
            switch (p_menu)
            {
                 case DirectoryChoice.StoreFloor:
                    return new StoreFloor();
                    

                    case DirectoryChoice.ShowStoreFront:
                    return new ShowStoreFront(new StoreFrontBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    

                    case DirectoryChoice.ProductSearch:
                    return new ProductSearch(new ItemsBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    

                    case DirectoryChoice.ProdSearchResult:
                    return  new ProdSearchResult(new ItemsBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    

                    case DirectoryChoice.ProductPage:
                    return new ProductPage();
                    
                    case DirectoryChoice.AddOrder:
                    return new AddOrders(new OrdersBL(new RepositoryCloud( new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.AddLineItem:
                    return new AddLineItem(new LineItemBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));


                    case DirectoryChoice.MainInventory:
                    return new MainInventory(new ItemsBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    

                    case DirectoryChoice.NewCustomer:
                    return new NewCustomer(new CustomersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    
                    
                    case DirectoryChoice.ShowCustomers:
                    return new ShowCustomers(new CustomersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    

                    case DirectoryChoice.CustomerPage:
                    return new CustomerPage();
                    

                    
                    case DirectoryChoice.ShowProduct:
                    return new ShowProduct(new ItemsBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    
                    case DirectoryChoice.SearchCustomer:
                    return new SearchCustomer(new CustomersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.EmailSearchResult:
                    return new EmailSearchResult(new CustomersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));
                    
                    case DirectoryChoice.SearchResult:
                    return new SearchResult(new CustomersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.ShowStore:
                    return new ShowStore(new StoreFrontBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.StoreSelect:
                    return new StoreSelect(new StoreFrontBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.CollectOrder:
                    return new CollectOrder(new OrdersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))),(new LineItemBL(new RepositoryCloud(new SupplyShopDatabaseContext(options)))));

                    case DirectoryChoice.InitiateOrder:
                    return new InitiateOrder(new OrdersBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.UpdateProd:
                    return new UpdateProd(new ItemsBL(new RepositoryCloud(new SupplyShopDatabaseContext(options))));

                    case DirectoryChoice.StoreFrontMain:
                    return new StoreFrontMain();
                    
                   

                    
                    

                    default:
                    return null;
            }
        }
    }
}