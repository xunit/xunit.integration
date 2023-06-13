#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using Xunit;

public class xUnit1025
{
    [Theory]
    [InlineData(2)]
    [InlineData(2)]
    public void TestMethod(int x)
    { }

    [Theory]
    [InlineData(2, 0)]
    [InlineData(2)]
    public void TestMethod2(int x, int y = 0)
    { }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(new object[] { 1, 2, 3 })]
    public void TestMethod3(params int[] args)
    { }
}
