using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        [Test]
        public void AddProduct()
        {
            Basket basket = new Basket();

            basket.AddProduct("Carrot", 2);

            Assert.IsTrue(basket.basket.Count == 1);
        }

        [Test]
        public void Checkout()
        {
            Basket basket = new Basket();
            basket.AddProduct("Carrot", 2);
            basket.AddProduct("Potato", 5);
            
            decimal total = basket.Checkout(basket.basket);

            Assert.IsTrue(total == 7);
        }
    }
}