#pragma warning disable xUnit1011 // There is no matching method parameter

using Xunit;

public class xUnit1006
{
    [Theory]
    [InlineData(12, "book")]
    public void TestMethod(int quantity, string productType)
    { }
}
