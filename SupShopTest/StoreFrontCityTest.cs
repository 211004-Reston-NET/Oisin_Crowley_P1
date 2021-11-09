using System;
using Xunit;
using SupplyShopModels;

namespace SupShopTest
{
    public class StoreFrontCityTest
    {
        /// <summary>
        /// Will test if the phone property will set with valid data
        /// valid data is anything with numbers in phone number pattern
        /// </summary>
        [Fact]
        public void SFCityShouldSetValidData()
        {
            // Arrange 
            StoreFront _sfcityTest = new StoreFront();
            string city = "Boston";

            // 
            _sfcityTest.City = city;


            //Assert 

            Assert.NotNull(_sfcityTest.City);
            Assert.Equal(_sfcityTest.City, city);

        }

        [Fact]
            /// <summary>
            /// Will fail if it is not in a city or if it has numbers 
            /// </summary>
        public void CityShouldfailwithInvalidData()
        {
            StoreFront _sfcityTest = new StoreFront();
            string city = "1234a32345";


            //act 
            //;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _sfcityTest.City = city);
           
        }
    }
}
