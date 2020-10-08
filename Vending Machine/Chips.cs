using System.Collections.Generic;
using System.ComponentModel;

namespace Vending_Machine
{
    public class Chips : Products
    {
        public const string message = " Hungry eh? Enjoy your salty snacks!";

        public Chips (string productCode, string productName, int price) : base(message, productCode, productName, price)
        {

        }
    }
}
