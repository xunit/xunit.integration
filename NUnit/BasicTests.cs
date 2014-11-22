using NUnit.Framework;

namespace NUnit
{
    public class BasicTests
    {
        [Test]
        public void Passing()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Failing()
        {
            Assert.IsTrue(false);
        }
    }
}
