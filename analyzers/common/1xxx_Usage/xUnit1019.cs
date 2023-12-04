#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.Collections.Generic;
using Xunit;

public class xUnit1019
{
    public static IEnumerable<object> TestData;

    // For v2, the only fixer offered should be to convert to IEnumerable<object[]>
    // For v3, it should also offer a fixer to convert to IEnumerable<ITheoryDataRow>
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string _1, int _2) { }

#if XUNIT_V3
    public static List<Xunit.Sdk.TheoryDataRow> V3TestData;

    // This should not trigger with v3
    [Theory]
    [MemberData(nameof(V3TestData))]
    public void SkippedDataRow(int _1, string _2) { }
#endif
}
