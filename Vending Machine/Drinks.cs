using System.IO;
using System;
using System.Text;
using System.Collections.Generic; 
using System.Net.Http;

namespace Vending_Machine
{
    public class Drinks : Product
    {
        public Drinks ()
        {
            this.ProductCode = "C1";
            this.ProductName = "Coke";
            this.Price = 15;
            this.Action = "Feeling thirsty? Enjoy this cold drink!";
        }

    }

}

