#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using System.Collections.Generic;
using Xunit;

public class xUnit1020
{
    public static IEnumerable<object[]> TestData { private get; set; }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string greeting, int age) { }
}
