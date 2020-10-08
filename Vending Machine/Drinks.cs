using System.IO;
using System;
using System.Text;
using System.Collections.Generic; 
using System.Net.Http;

namespace Vending_Machine
{
    public class Drinks : Products
    {
        public const string message = " Thirty eh? Enjoy your cold drink!";

        public Drinks (string productCode, string productName, int price) : base (message, productCode, productName, price)           
        {

        }
    }
}
