using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<String, decimal> basket = new Dictionary<String, decimal>();

        public void AddProduct(String productName, decimal cost)
        {
            basket.Add(productName, cost);
        }

        public decimal Checkout(Dictionary<String, decimal> products)
        {
            decimal total = 0;

            foreach (var product in products)
            {
                total += product.Value;
            }

            return total;
        }
        
    }
}
