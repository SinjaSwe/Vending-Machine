using System.Collections.Generic;

namespace Vending_Machine
{
    public class Candy : Product

    {
        public Candy()
        {
            this.ProductCode = "A1";
            this.ProductName = "Mars";
            this.Price = 12;
            this.Action = " Time for a sugar hit? Enjoy your candy!";
        }          
        
    }
}
