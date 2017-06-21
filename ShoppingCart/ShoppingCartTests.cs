using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void FirstCartTest()
        {
            var shoppingCart = new Product[2] { new Product("castraveti", 10f), new Product("rosii", 20f) };
            Assert.AreEqual(30, CalculateTotal(shoppingCart));
        }

        public struct Product
        {
            public string productName;
            public float price;

            public Product(string productName, float price)
            {
                this.productName = productName;
                this.price = price;
            }
        }

        float CalculateTotal(Product[] shoppingCart)
        {
            float sum = 0;
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                sum += shoppingCart[i].price  ;
            }
            return sum;
        }
    }
}
