using System.Collections.Generic;
using Xunit;

public class xUnit1042
{
    public static IEnumerable<object[]> TestData = new[] { new object[] { 42 }, new object[] { 2112 } };

    [Theory]
    [MemberData(nameof(TestData))]
    public static void TestMethod(int _)
    { }
}
