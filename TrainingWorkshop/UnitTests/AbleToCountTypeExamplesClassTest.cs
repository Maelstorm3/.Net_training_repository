using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesAndInterfaces.Task_2;

namespace UnitTests
{
    [TestClass]
    public class AbleToCountTypeExamplesClassTest
    {
        /// <summary>
        /// Ables to count type examples class test method.
        /// </summary>
        [TestMethod]
        public void AbleToCountTypeExamplesClassTestMethod()
        {
            AbleToCountTypeExamplesClass a = new AbleToCountTypeExamplesClass();
            AbleToCountTypeExamplesClass b = new AbleToCountTypeExamplesClass();
            AbleToCountTypeExamplesClass c = new AbleToCountTypeExamplesClass();
            Assert.AreEqual(3, AbleToCountTypeExamplesClass.CountOfExamples);
        }
    }
}
