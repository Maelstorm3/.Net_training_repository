using ClassesAndInterfaces.Task_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonTestMethod()
        {
            Person p = new Person();
            p.AddChild("1", 1);
            p.AddChild("2", 2);
            Assert.AreEqual(2, p.GetChildrenCount());
        }
    }
}
