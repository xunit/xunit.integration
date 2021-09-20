#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using System.Collections.Generic;
using Xunit;

public class xUnit1014
{
    public static IEnumerable<object[]> TestData;

    [Theory]
    [MemberData("TestData")]
    public void TestMethod(string greeting, int age) { }
}
