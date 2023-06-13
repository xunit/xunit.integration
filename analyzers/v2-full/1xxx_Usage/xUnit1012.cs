#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using Xunit;

public class xUnit1012
{
    [Theory]
    [InlineData(null)]
    public void TestMethod(int _) { }
}
