using System;
using Xunit;
using SupplyShopDL;
using Microsoft.EntityFrameworkCore;
using SupplyShopModels;
using System.Collections.Generic;
using System.Linq;

namespace SupShopTest
{
    public class CustomerRepoTests
    {
        private readonly DbContextOptions<SupplyShopDatabaseContext> _options;

        public CustomerRepoTests()
        {
            _options = new DbContextOptionsBuilder<SupplyShopDatabaseContext>()
                            .UseSqlite("Filename = test.db").Options;
                Seed();            
        }
        [Fact]
        public void GetAllCustomerShouldReturnAllItems()
        {
            using (var context = new SupplyShopDatabaseContext(_options))
            {
                 //Arrange 
                 IRepository repo = new  RepositoryCloud(context);

                 //act 
                 var test = repo.GetAllCustomers();

                 //Assert
                 Assert.Equal(test.Count, 2);
                 
            }
        }
        [Fact]
        public void AddCustomerShouldAddAProduct()
        {
            using (var context = new SupplyShopDatabaseContext(_options))
            {   //arrange
                IRepository repo = new RepositoryCloud(context);
                Customers addCust = new Customers
                {
                    CustomerName = "Billy",
                    CustStreetAdd = "222 Stovetop",
                    CustCity = "Plymouth",
                    CustState = "Ma",
                    CustPhone = "4444544321",
                    CustEmail = "test@test.com",
                    CustZip = 33333
                };

                //act
                repo.AddCustomer(addCust);

                //assert


                
                 
            }

            using (var context = new SupplyShopDatabaseContext(_options))
            {
                Customers result = context.Customers.Find(3);

                Assert.Equal("Billy", result.CustomerName);   
                Assert.Equal("Plymouth", result.CustCity);
            }
        }

        [Fact]
        public void DeleteCustomerShouldDeleteCustomer()
        {
            using (var context = new SupplyShopDatabaseContext(_options))
            {
                 IRepository repo = new RepositoryCloud(context);
                 Customers cust = new Customers
                 {
                     CustomerId = 1,
                        CustomerName = "John",
                            CustStreetAdd = "123 faketone",
                            CustCity = "Atl",
                            CustState = "Ga",
                            CustZip = 22222,
                            CustEmail = "Faketown@test.com",
                            CustPhone = "2222222222"
                 };

                 //act
                 repo.DeleteCust(cust);


            }

             using (var context = new SupplyShopDatabaseContext(_options))
            {
                List<Customers> listofcust = context.Customers.ToList();

                Assert.Single(listofcust);
                Assert.Null(context.Customers.Find(1));
                 
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


                    context.Customers.AddRange(
                        new Customers
                        {
                            CustomerName = "John",
                            CustStreetAdd = "123 faketone",
                            CustCity = "Atl",
                            CustState = "Ga",
                            CustZip = 22222,
                            CustEmail = "Faketown@test.com",
                            CustPhone = "2222222222"
                        },
                        new Customers
                        {
                            CustomerName = "Jane",
                            CustStreetAdd = "123 Smalltop",
                            CustCity = "Dallas",
                            CustState = "Texas",
                            CustZip = 33433,
                            CustEmail = "SillyString@test.com",
                            CustPhone = "2322322222"
                        }
                        
                    );

                    context.SaveChanges();
                    
                        
                        
                    
                

            }
        }
    }
}