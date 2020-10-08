using System;
using System.Collections.Generic;

namespace Vending_Machine
{
    public class Products
    {
        //Properties
        public string productType { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int price { get; set; }        
        public string action { get; set; }            
       
        public Products() //constructor
        {

        }

        public Products(string productCode, string productName, int price) //constructor
        {           
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
        }


        public Products (string productType, string productCode, string productName, int price) //constructor
        {
            this.productType = productType; 
            this.productCode = productCode; 
            this.productName = productName;
            this.price = price;            
        }

        
        public string ProductCode
        {
            get
            {
                return this.productCode; 
            }
        }

        public void ExamineProduct()
        {
            Console.WriteLine($"Product Information: Product Type: {productType} \nProductName: {productName} \nPrice: {price} \n\n");
        }


    }

    

}
