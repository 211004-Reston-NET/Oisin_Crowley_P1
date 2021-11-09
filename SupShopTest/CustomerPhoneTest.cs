using System;
using Xunit;
using SupplyShopModels;

namespace SupShopTest
{
    public class CustomerPhoneTest
    {
        /// <summary>
        /// Will test if the phone property will set with valid data
        /// valid data is anything with numbers in phone number pattern
        /// </summary>
        [Fact]
        public void PhoneShouldSetValidData()
        {
            // Arrange 
            Customers _custTest = new Customers();
            string phone = "1233333433";

            // 
            _custTest.CustPhone = phone;


            //Assert 

            Assert.NotNull(_custTest.CustPhone);
            Assert.Equal(_custTest.CustPhone, phone);

        }

        [Fact]
            /// <summary>
            /// Will fail if it is not in a phone number or if it has letters 
            /// </summary>
        public void PhoneShouldfailwithInvalidData()
        {
            Customers _custTest = new Customers();
            string phone = "1234a32345";


            //act 
            //_custTest.Phone = phone;


            //assert and act 
            /// inside para mini function a delegate left side states parameters and right side is the implementation detail of the method. 
            /// it is like writing a method inside a parameter
            Assert.Throws<Exception>(() => _custTest.CustPhone = phone);
           
        }
    }
}
