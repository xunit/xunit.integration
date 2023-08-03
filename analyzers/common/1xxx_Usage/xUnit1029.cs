#pragma warning disable CS8321 // Local function is declared but never used

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
