#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using System;
using Xunit;

public class xUnit1018
{
    public static event EventHandler TestData;

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string greeting, int age) { }
}
