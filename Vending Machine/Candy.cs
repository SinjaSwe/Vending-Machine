using System.Collections.Generic;

namespace Vending_Machine
{
    public class Candy : Products

    {
        public const string message = " Time for a sugar hit? Enjoy your candy!";

        public Candy (string productCode, string productName, int price) : base(message, productCode, productName, price)
        {

        }
    }
}
