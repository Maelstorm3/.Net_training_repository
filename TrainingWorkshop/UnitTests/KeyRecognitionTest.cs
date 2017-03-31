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
            IKey magKey = new MagneticKey(KeyTypes.MagneticKey);
            IKey metKey = new MetalKey(KeyTypes.MetalKey);
            Assert.AreEqual(KeyTypes.MagneticKey, magKey.KeyType);
            Assert.AreEqual(KeyTypes.MetalKey, metKey.KeyType);
        }
    }
}
