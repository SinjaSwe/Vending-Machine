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
        public string ProductType { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }        
        public string Action { get; set; }            
       

        public void PurchaseComplete (int price, int moneyPoolPot)       
        {               
            if (moneyPoolPot >= price)
            {
                --moneyPoolPot;
            }

            else
            { 
                Console.WriteLine("Insufficient funds. Please feed some more coins into the machine"); 
            }
        }

        public string ExamineProduct()
        {
            return $"Product Information: Product Type: {this.ProductType} \nProductName: {this.ProductName} \nPrice: {this.Price} \n\n" ;
        }

        public string Use ()
        {
            return $"Product Instructions: {this.Action}"; 
        }

        // Insufficient funds
        public string NoMoney(int price, int moneyPoolPot)
        {

        }


    }



}
