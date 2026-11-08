#pragma warning disable CS0067
#pragma warning disable CS8618

using System;
using Xunit;

public class xUnit1018
{
    public static event EventHandler TestData;

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string _1, int _2) { }
}
