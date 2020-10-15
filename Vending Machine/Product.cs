using System;
using System.Collections.Generic;

namespace Vending_Machine
{
    public abstract class Product
    {
        //fields
        private string productType;
        private string productCode;
        private string productName;
        private int price;
        private string action; 

        //Properties
        public string ProductType { get { return productType; } }
        public string ProductCode { get { return productCode; } }
        public string ProductName { get { return productName; } }
        public int Price { get { return price; } }        
        public string Action { get { return action; } }

        public bool PurchaseComplete(int moneyPoolPot, int price)
        {
            bool purchaseComplete = false;

            if (moneyPoolPot >= price)
            {
                purchaseComplete = true;
            }

            else
            {
                Console.WriteLine("Insufficient funds");
            }

            return purchaseComplete;
        }

       
        public string ExamineProduct()
        {
            return $"Product Information: Product Type: {this.ProductType} \nProductName: {this.ProductName} \nPrice: {this.Price} \n\n" ;
        }

        public string Use ()
        {
            return $"Product Instructions: {this.Action}"; 
        }

        
    }



}
