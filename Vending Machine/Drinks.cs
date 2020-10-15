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
            string productCode = "C1";
            string productName = "Coke";
            int price = 15;
            string action = "Feeling thirsty? Enjoy this cold drink!";
        }

    }

}

