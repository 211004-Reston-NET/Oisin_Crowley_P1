using System;
using Xunit;
using SupplyShopModels;

namespace SupShopTest
{
    public class ItemDescTest

    {
        /// <summary>
        /// Will test if the phone property will set with valid data
        /// valid data is anything with numbers in phone number pattern
        /// </summary>
        [Fact]
        public void ItDescShouldSetValidData()
        {
            // Arrange 
            Items _itdescTest = new Items();
            string itdesc = "A large Note pad for writing";

            // act
            _itdescTest.ItemDesc = itdesc;


            //Assert 

            Assert.NotNull(_itdescTest.ItemDesc);
            Assert.Equal(_itdescTest.ItemDesc, itdesc);

        }

        [Fact]
            /// <summary>
            /// Will fail if it is not in a city or if it has numbers 
            /// </summary>
        public void ItDescShouldfailwithInvalidData()
        {
            Items _itdescTest = new Items();
            string itdesc = "a &arge N0tep@d";


            //act 
            //;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _itdescTest.ItemDesc = itdesc);
           
        }
    }
}