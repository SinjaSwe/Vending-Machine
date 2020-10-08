using System;
using Xunit;
using Vending_Machine; 

namespace ProductTests
{
    public class ProductTests
    {
        /* TEST TEMPLATE
        
        [Fact]
        public void Test1()
        {
            //Arrange
            //Act
            //Assert

        }*/


        [Fact]
        public void PurchaseCompleteTest()
        {

            //Arrange
            Product pro = new Product();
            int price = 23;
            int moneyPoolPot = 100;
            int expected = 77;

            //Act
            var result = pro.PurchaseComplete(price, moneyPoolPot);

            //Assert
            Assert.Equal(expected, result); 

        }
        


}
