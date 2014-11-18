using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_and_v2
{
    [TestClass]
    public class BasicTests_MSTest
    {
        [TestMethod]
        public void Passing()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Failing()
        {
            Assert.IsTrue(false);
        }
    }
}
