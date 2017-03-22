using ClassesAndInterfaces.Task_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Summary description for KeyRecognitionTest
    /// </summary>
    [TestClass]
    public class KeyRecognitionTest
    {
        [TestMethod]
        public void KeyRecognitionTestMethod()
        {
            IKey magKey = new MagneticKey("Magnetic");
            IKey metKey = new MetalKey("Metal");
            Assert.AreEqual("Magnetic", magKey.KeyType);
            Assert.AreEqual("Metal", metKey.KeyType);
        }
    }
}
