using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class BasicTests
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
