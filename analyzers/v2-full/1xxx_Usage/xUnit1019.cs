#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.Collections.Generic;
using Xunit;

public class xUnit1019
{
    public static IEnumerable<object> TestData;

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string _1, int _2) { }
}
