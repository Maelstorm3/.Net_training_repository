using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesAndInterfaces.Task_2;

namespace UnitTests
{
    [TestClass]
    public class TypeExamplesCounterTest
    {
        /// <summary>
        /// Ables to count type examples class test method.
        /// </summary>
        [TestMethod]
        public void TypeExamplesCounterTestMethod()
        {
            TypeExamplesCounter a = new TypeExamplesCounter();
            TypeExamplesCounter b = new TypeExamplesCounter();
            TypeExamplesCounter c = new TypeExamplesCounter();
            Assert.AreEqual(3, TypeExamplesCounter.Count);
        }
    }
}
