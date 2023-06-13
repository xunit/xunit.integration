#pragma warning disable CS0067    // The event 'xUnit1018.TestData' is never used
#pragma warning disable CS8618    // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
