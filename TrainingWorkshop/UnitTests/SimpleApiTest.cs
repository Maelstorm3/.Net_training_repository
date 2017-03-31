using ClassesAndInterfaces.Task_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class SimpleApiTest
    {
        SimpleApi mApi = new SimpleApi(new Basket());
        [TestMethod]
        public void SimpleApiTestMethod()
        {
          var firstProduct=  mApi.Post(new Product(1) { Name="1", Cost=1});
          var secondProduct = mApi.Post(new Product(2) { Name = "2", Cost = 2 });
          var thirdProduct = mApi.Post(new Product(3) { Name = "3", Cost = 3 });
            var sum = mApi.GetTotalSum();
            Assert.AreEqual(6, sum);
            var allProducts = mApi.Get();
            var deletedProduct = mApi.Delete(allProducts.Where(p => p.Id == 2).FirstOrDefault());
            sum = mApi.GetTotalSum();
            Assert.AreEqual(4, sum);
        }
    }
}
