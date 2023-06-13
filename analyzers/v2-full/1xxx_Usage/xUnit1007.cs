#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using Xunit;

class xUnit1007_TestData { }

public class xUnit1007
{
    [Theory]
    [ClassData(typeof(xUnit1007_TestData))]
    public void TestMethod(int quantity, string productType)
    { }
}
