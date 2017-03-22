using ClassesAndInterfaces.Task_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SimpleApiTest
    {
        [TestMethod]
        public void SimpleApiTestMethod()
        {
            SimpleApi.Post(new Product(1) { Cost = 10, Name = "1" });
            SimpleApi.Post(new Product(2) { Cost = 11, Name = "2" });
            SimpleApi.Post(new Product(3) { Cost = 12, Name = "3" });
            SimpleApi.Delete(Basket.ProductCollection[1]);
            Assert.AreEqual(22, SimpleApi.GetTotalSum());
        }
    }
}
