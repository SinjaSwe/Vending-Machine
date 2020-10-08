using System.Collections.Generic;

namespace Vending_Machine
{
    public class ListOfProducts : Products
    {
        public List<Products> items = new List<Products> //create list
        {
            new Products {productType = "Candy", productCode = "1A", productName = "Mars", price = 12},
            new Products {productType = "Candy", productCode = "1B", productName = "Crunchie", price = 15},
            new Products {productType = "Candy", productCode = "1C", productName = "Milky Way", price = 10},
            new Products {productType = "Candy", productCode = "1D", productName = "Twix", price = 12},
            new Products {productType = "Candy", productCode = "1E", productName = "Toffee", price = 12},

            new Products {productType = "Drink", productCode = "2A", productName = "Fanta", price = 12},
            new Products {productType = "Drink", productCode = "2B", productName = "Coke", price = 12},
            new Products {productType = "Drink", productCode = "2C", productName = "Sprite", price = 12},
            new Products {productType = "Drink", productCode = "2D", productName = "Orange Juice", price = 12},
            new Products {productType = "Drink", productCode = "2E", productName = "Apple Juice", price = 12},

            new Products {productType = "Chips", productCode = "3A", productName = "Cheese & Onion", price = 12},
            new Products {productType = "Chips", productCode = "3B", productName = "Salt & Vingear", price = 14},
            new Products {productType = "Chips", productCode = "3C", productName = "Ready Salted", price = 15},
            new Products {productType = "Chips", productCode = "3D", productName = "Pringles Red", price = 20},
            new Products {productType = "Chips", productCode = "3E", productName = "Pringles Green", price = 20}

            };

        public List<Products> Items //declare list as propery 
            {
                get { return items; }
            }

    

        

        public string ProductInformation (string productType, string productName, int price)
        {
            return $"Product Information: Product Type: {productType} \nProductName: {productName} \nPrice: {price} \n\n";
        }

        /*

        ProductList[] items = new ProductList[12];

        public ListofProducts
        {            
            items[0] = new Candy("Mars", 13, "Enjoy your snack", "A1")
            items[1] = new Candy()
            items[2] = new Candy()
            items[3] = new Candy()
            items[4] = new Candy()

            items[5] = new Drinks()
            items[6] = new Drinks()
            items[7] = new Drinks()
            items[8] = new Drinks()
            items[9] = new Drinks()

            items[10] = new Chips()
            items[11] = new Chips()
            items[12] = new Chips()
            items[13] = new Chips()
            items[14] = new Chips()
        }

          public Array Items { get { return items; } }  
        */





    }



}

    

