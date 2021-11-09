using System;
using Xunit;
using SupplyShopModels;

namespace SupShopTest
{
    public class ItemCatTest

    {
        /// <summary>
        /// Will test if the phone property will set with valid data
        /// valid data is anything with numbers in phone number pattern
        /// </summary>
        [Fact]
        public void ItCatShouldSetValidData()
        {
            // Arrange 
            Items _itcatTest = new Items();
            string itdesc = "Category";

            // act
            _itcatTest.ItemDesc = itdesc;


            //Assert 

            Assert.NotNull(_itcatTest.ItemDesc);
            Assert.Equal(_itcatTest.ItemDesc, itdesc);

        }

        [Fact]
            /// <summary>
            /// Will fail if it is not in a city or if it has numbers 
            /// </summary>
        public void ItCatShouldfailwithInvalidData()// fact is a test case with no parameters and will only run once. 
        {
            Items _itcatTest = new Items();
            string itcat = "a &arge N0tep@d";


            //act 
            //;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _itcatTest.ItemDesc = itcat);
           
        }

        /// <summary>
        /// Will test if the category property gives exception if given invalid data
        /// invalid data is anything but letters 
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// Theory from fact to parameterize test cases
        [Theory]
        [InlineData("Org@nization")] //inline data will be the data being passed to the parmeter of this method to be tested on
        [InlineData("7Fluid2s")] // you can add more data
        [InlineData("Cont@ainter!")]
        public void ItCatShouldFailAllTheseTests(string p_input) //can  also pass in multiple parameters 
        {
            // Arrange does need the string initiated when doing inline data as we feed in mulitple items
            Items _itcatTest = new Items();
            


            //act 
            //;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _itcatTest.ItemDesc = p_input);
        }
    }
}