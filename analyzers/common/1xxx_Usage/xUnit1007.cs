using Xunit;

class xUnit1007_TestData { }

public class xUnit1007
{
    [Theory]
    [ClassData(typeof(xUnit1007_TestData))]
    public void TestMethod(int _1, string _2)
    { }
}
