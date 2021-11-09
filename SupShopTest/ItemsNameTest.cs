using System;
using Xunit;
using SupplyShopModels;

namespace SupShopTest
{
    public class ItemNameTest

    {
        /// <summary>
        /// Will test if the phone property will set with valid data
        /// valid data is anything with numbers in phone number pattern
        /// </summary>
        [Fact]
        public void ItNameShouldSetValidData()
        {
            // Arrange 
            Items _itnameTest = new Items();
            string itName = "Note Pad";

            // 
            _itnameTest.itemName = itName;


            //Assert 

            Assert.NotNull(_itnameTest.itemName);
            Assert.Equal(_itnameTest.itemName, itName);

        }

        [Fact]
            /// <summary>
            /// Will fail if it is not in a city or if it has numbers 
            /// </summary>
        public void ItNameShouldfailwithInvalidData()
        {
            Items _itnameTest = new Items();
            string city = "1234a32345";


            //act 
            //;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _itnameTest.itemName = city);
           
        }
    }
}