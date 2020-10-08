using System;
using Xunit;
using Vending_Machine; 


namespace VendingMachineTests
{
    public class VendingMachineTests
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
        public void DepositCoinTest()
        {
            //Arrange
            MoneyPool mP = new MoneyPool(); //instance of the class
            int moneyPoolPot = 100;
            int coin = 20;
            int expected = 120; 

            //Act
            var result = mP.DepositCoin(moneyPoolPot, coin); 

            //Assert

            Assert.Equal(result, expected); 

         }

        [Fact]
        public void PurchaseItemTest()
        {
            //Arrange
            MoneyPool mP = new MoneyPool(); //instance of the class
            string productCode = "A1"; 
            string enteredCode = "A1";
            bool expected = true; 

            //Act

            var result =  mP.PurchaseItem(productCode, enteredCode);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnChangeTest()
        {
            //Arrange
            MoneyPool mP = new MoneyPool(); //instance of the class
            int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            int moneyPoolPot = 121;

            //Act
            mP.ReturnChange(denominations, moneyPoolPot);

            //Assert
            Assert.

        }
    }
