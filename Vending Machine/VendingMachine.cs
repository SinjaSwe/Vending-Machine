using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Vending_Machine
{

    public class VendingMachine
    {
        private List<Product> productList;
        public List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }
    }
}
