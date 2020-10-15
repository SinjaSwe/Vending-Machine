using System;
using Xunit;
using Vending_Machine;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

namespace ProductTests
{
    public class ProductTests
    {
        [Fact]
        public void PurchaseComplete()
        {
            //Arrange            
            
            Product product = new Candy();                        
            int moneyPoolPot = 5;
            int price = 4; 

            //Act
            bool result = product.PurchaseComplete(moneyPoolPot, price);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void PurchaseNotComplete()
        {
            //Arrange            
            Product product = new Candy();
            int moneyPoolPot = 5;
            int price = 20;

            //Act
            bool result = product.PurchaseComplete(moneyPoolPot, price);

            //Assert
            Assert.False(result);
        }

    }      

           
}