#pragma warning disable CS8321

using Xunit;

public class xUnit1029
{
    public void NonTestMethod()
    {
        [Fact]
        void LocalTestMethod()
        { }
    }
}
