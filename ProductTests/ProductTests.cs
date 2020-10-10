using System;
using Xunit;
using Vending_Machine;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

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

        public void PurchaseComplete()
        {
            //Arrange            
            Product product = new Product();                        
            int moneyPoolPot = 5;
            int price = 4; 

            //Act
            bool result = product.PurchaseComplete(moneyPoolPot, price);

            //Assert
            Assert.True(result);
        }

        public void PurchaseNotComplete()
        {
            //Arrange            
            Product product = new Product();
            int moneyPoolPot = 5;
            int price = 20;

            //Act
            bool result = product.PurchaseComplete(moneyPoolPot, price);

            //Assert
            Assert.False(result);
        }

    }

        /*
        
       [Fact]
        public void PurchaseCompleteTest()
        {

            //Arrange
            var sut = new Mock<Products>();
            

            int price = 23;
            int moneyPoolPot = 100;
            int expected = 77;

            sut.Setup(x => x.PurchaseComplete).Return(price, moneyPoolPot);

            //Act
            var actual = sut.Object.GetThePurchaseComplete();

            //Assert 
            
            Assert.Throws
            Assert.Equal(expected, actual);
        }*/

    }
       
}