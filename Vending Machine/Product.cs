﻿using System;
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
       
        public Product() //constructor
        {

        }

        public Product(string productCode, string productName, int price) //constructor
        {           
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
        }

        public Product (string productType, string productCode, string productName, int price) //constructor
        {
            this.productType = productType; 
            this.productCode = productCode; 
            this.productName = productName;
            this.price = price;            
        }


        public bool PurchaseComplete (int price, int moneyPoolPot)       
        {               
            bool purchaseComplete = false;

            if (moneyPoolPot >= price)
            {
                -- moneyPoolPot
            }
            return purchaseComplete;
        }

        public string ExamineProduct()
        {
            return $"Product Information: Product Type: {this.ProductType} \nProductName: {this.ProductName} \nPrice: {this.Price} \n\n");
        }

        public string Use ()
        {
            return $"Product Instructions: {this.Action}"; 
        }


    }

    

}