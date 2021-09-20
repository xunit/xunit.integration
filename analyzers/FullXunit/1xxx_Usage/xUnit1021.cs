#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using System.Collections.Generic;
using Xunit;

public class xUnit1021
{
    public static IEnumerable<object[]> TestData { get; set; }

    [Theory]
    [MemberData(nameof(TestData), "Hello world", 123)]
    public void TestMethod(int _) { }
}
