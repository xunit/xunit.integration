using Xunit;

namespace NUnit_and_v2
{
    public class BasicTests_xUnit
    {
        [Fact]
        public void Passing()
        {
            Assert.True(true);
        }

        [Fact]
        public void Failing()
        {
            Assert.True(false);
        }

        [Theory]
        [InlineData(2112)]
        [InlineData("hello")]
        [InlineData(null)]
        public void Theory(object value)
        {
            Assert.NotNull(value);
        }
    }
}
