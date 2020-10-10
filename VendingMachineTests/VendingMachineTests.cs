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
        public void Test1()
        {
            //Arrange
            MoneyPool mP = new MoneyPool();
            int expected = 5;

            //Act

            mP.DepositACoin(5);

            //Assert
            Assert.Equal(expected, mP.MoneyPoolPot);
        }


        [Fact]

        public void DepositCoinTest()
        {
            //Arrange            
            MoneyPool moneyPool = new MoneyPool(); //instance of the class              
            int coin = 5;

            //Act
            bool result = moneyPool.DepositCoin(coin); 


            moneyPool.DepositCoin(5); //Add 5 to pot

            //Assert
            Assert.True (result);
        }

        [Fact]
        public void DepositWrongCoinTest()
        {
            //Arrange
            MoneyPool moneyPool = new MoneyPool(); //instance of the class              
            int coin = 6;

            //Act
            bool result = moneyPool.DepositCoin(coin);

            //Assert

            Assert.False(result);
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

            var result = mP.PurchaseItem(productCode, enteredCode);

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
        



            //Assert
            
        }
    }
}