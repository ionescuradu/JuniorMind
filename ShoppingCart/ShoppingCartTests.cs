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

        [TestMethod]
        public void SecontCartTest()
        {
            var shoppingCart = new Product[4] { new Product("castraveti", 10f), new Product("rosii", 20f), new Product("mere", 25f), new Product("gutui", 40f) };
            Assert.AreEqual(95, CalculateTotal(shoppingCart));
        }

        [TestMethod]
        public void FirstTestCheapest()
        {
            var shoppingCart = new Product[2] { new Product("castraveti", 10f), new Product("rosii", 20f) };
            Assert.AreEqual("castraveti", CheapestProduct(shoppingCart));
        }

        [TestMethod]
        public void SecondTestCheapest()
        {
            var shoppingCart = new Product[4] { new Product("castraveti", 10f), new Product("rosii", 5f), new Product("mere", 25f), new Product("gutui", 40f) };
            Assert.AreEqual("rosii", CheapestProduct(shoppingCart));
        }

        [TestMethod]
        public void FirstTestEliminateExpensive()
        {
            var shoppingCart = new Product[2] { new Product("castraveti", 10f), new Product("rosii", 20f) };
            Assert.AreEqual(1, ExpensiveProduct(shoppingCart));
        }

        [TestMethod]
        public void SecondTestEliminationExpensive()
        {
            var shoppingCart = new Product[4] { new Product("castraveti", 10f), new Product("rosii", 5f), new Product("mere", 40f), new Product("gutui", 40f) };
            Assert.AreEqual(2, ExpensiveProduct(shoppingCart));
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

        string CheapestProduct(Product[] shoppingCart)
        {
            return cheapestArticle(shoppingCart);
        }

        int ExpensiveProduct(Product[] shoppingCart)
        {
            var price = shoppingCart[0].price;
            var index = 0;
            for (int i = 1; i < shoppingCart.Length; i++)
            {
                if (price <= shoppingCart[i].price)
                {
                    price = shoppingCart[i].price;
                    index += 1;
                }
            }
            Product[] resizedShoppingCart = new Product[shoppingCart.Length - index];
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                if (price != shoppingCart[i].price)
                {
                    resizedShoppingCart[i].price = shoppingCart[i].price;
                    resizedShoppingCart[i].productName = shoppingCart[i].productName;
                }
            }
            return resizedShoppingCart.Length;
        }

        private static string cheapestArticle(Product[] shoppingCart)
        {
            string cheapest = shoppingCart[0].productName;
            var price = shoppingCart[0].price;
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                if (price > shoppingCart[i].price)
                {
                    price = shoppingCart[i].price;
                    cheapest = shoppingCart[i].productName;
                }
            }

            return cheapest;
        }
    }
}
