#pragma warning disable CS8618    // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using System.Collections.Generic;
using Xunit;

public class xUnit1017
{
    public IEnumerable<object[]> TestData;

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string greeting, int age) { }
}
