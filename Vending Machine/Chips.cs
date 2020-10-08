using System.Collections.Generic;
using System.ComponentModel;

namespace Vending_Machine
{
    public class Chips : Product
    {
        public Chips()
        {
            this.ProductCode = "B1";
            this.ProductName = "Pringles";
            this.Price = 23;
            this.Action = "Once you pop, you can't stop!";
        }

    }
}

