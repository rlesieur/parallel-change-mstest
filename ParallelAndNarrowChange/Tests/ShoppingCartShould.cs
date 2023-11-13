using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelAndNarrowChange.Field;

namespace ParallelAndNarrowChange{
    [TestClass]
    public class ShoppingCartShould{
        private ShoppingCart cart;

        [TestInitialize]
        public void SetUp(){
            cart = new ShoppingCart();
        }

        [TestMethod]
        public void calculate_the_final_price(){
            cart.Add(10);

            Assert.AreEqual(10, cart.CalculateTotalPrice());
        }

        [TestMethod]
        public void knows_the_number_of_items(){
            cart.Add(10);

            Assert.AreEqual(1, cart.NumberOfProducts());
        }

        [TestMethod]
        public void may_offer_discounts_when_there_at_least_one_expensive_product(){
            cart.Add(120);

            Assert.IsTrue(cart.HasDiscount());
        }

        [TestMethod]
        public void does_not_offer_discount_for_cheap_products(){
            cart.Add(10);

            Assert.IsFalse(cart.HasDiscount());
        }
    }
}
