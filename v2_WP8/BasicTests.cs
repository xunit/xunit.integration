using System;
using Xunit;

namespace v2_WP8
{
    public class BasicTests
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
