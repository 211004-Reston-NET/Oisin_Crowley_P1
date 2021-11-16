using System;
using Xunit;
using SupplyShopDL;
using Microsoft.EntityFrameworkCore;
using SupplyShopModels;
using System.Collections.Generic;
using System.Linq;

namespace SupShopTest
{
    public class StoreFrontRepoTest
    {
        private readonly DbContextOptions<SupplyShopDatabaseContext> _options;

        public StoreFrontRepoTest()
        {
            _options = new DbContextOptionsBuilder<SupplyShopDatabaseContext>()
                            .UseSqlite("Filename = test1.db").Options;
                Seed();            
        }
        [Fact]
        public void GetAllStorefrontShouldReturnAllItems()
        {
            using (var context = new SupplyShopDatabaseContext(_options))
            {
                 //Arrange 
                 IRepository repo = new  RepositoryCloud(context);

                 //act 
                 var test = repo.GetAllStores();

                 //Assert
                 Assert.Equal(test.Count, 2);
                 
            }
        }
        [Fact]
        public void AddStoreShouldAddAProduct()
        {
            using (SupplyShopDatabaseContext context = new SupplyShopDatabaseContext(_options))
            {   //arrange
                IRepository repo = new RepositoryCloud(context);
                StoreFront addStore = new StoreFront
                {
                    StoreName = "Billy World",
                    StreetAdd = "222 Stovetop",
                    City = "Plymouth",
                    State = "Ma",
                   
                    Zip = 33333
                };

                //act
                repo.AddStoreFront(addStore);

                //assert


                
                 
            }

            using (SupplyShopDatabaseContext context = new SupplyShopDatabaseContext(_options))
            {
                StoreFront result = context.StoreFronts.Find(3);

                Assert.Equal("Billy World", result.StoreName);   
                Assert.Equal("Plymouth", result.City);
            }
        }


        [Fact]
        public void DeleteStoreFrontShouldDeleteStoreFront()
        {
            using (var context = new SupplyShopDatabaseContext(_options))
            {
                 IRepository repo = new RepositoryCloud(context);
                 StoreFront store = new StoreFront
                 {
                        StoreID = 1,
                          StoreName = "Supply World",
                            StreetAdd = "123 faketone",
                            City = "Atl",
                            State = "Ga",
                            Zip = 22222
                 };

                 //act
                 repo.DeleteStore(store);


            }

            using (var context = new SupplyShopDatabaseContext(_options))
            {
                List<StoreFront> listofStore = context.StoreFronts.ToList();

                Assert.Single(listofStore);
                Assert.Null(context.StoreFronts.Find(1));
                 
            }
        }





        private void Seed()
        {   
            /// <summary>
            /// using block to automatically close the resource that is use to connect to this db after seeding data to it 
            /// </summary>
            /// <param name="context"></param>
            /// <returns></returns>
            using (var context = new SupplyShopDatabaseContext(_options))
            {       

                //we want to ensure the data gets deleted and created from previous tests. 
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();


                    context.StoreFronts.AddRange(
                        new StoreFront
                        {
                            StoreName = "Supply World",
                            StreetAdd = "123 faketone",
                            City = "Atl",
                            State = "Ga",
                            Zip = 22222
                            
                        },
                        new StoreFront
                        {
                            StoreName = "Supply Land",
                            StreetAdd = "123 Smalltop",
                            City = "Dallas",
                            State = "Texas",
                            Zip = 33433
                            
                        }
                        
                    );

                    context.SaveChanges();
                    
                        
                        
                    
                

            }
        }
    }
}