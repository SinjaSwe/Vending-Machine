using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Vending_Machine
{

    public class VendingMachine
    {
        
        int[] denonomincations = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        int moneyPool = 0;

        public void InitializeList()
        {
            ListOfProducts listOfProducts = new ListOfProducts();
            List<Products> mylist = listOfProducts.items; //access the GET accessor
        }

        int MoneyPool(int coin)
        {
            return moneyPool += coin;
        }

        bool DepositCoin (int enteredCoin)
        {
            if (denonomincations.Contains(enteredCoin))
            {
                MoneyPool(enteredCoin);
                return true;
            }
            else
            { 
                throw new InvalidOperationException("That coin is not accepted by the machine");
             }
        }                

        void PurchaseProduct (string productCodeSelected)        {
            
            
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].ItemID == productCodeSelected)
                {
                    items[i].Purchase(moneyPool);
                }
            }
        }

        void UseProduct (string message)
        {

        }
    }

        
}
