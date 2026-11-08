#pragma warning disable CS8618
#pragma warning disable xUnit1053

#if XUNIT_V3
#pragma warning disable xUnit1042
#endif

using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class xUnit1019
{
    public static IEnumerable<int> TestData;
    public static Task<IEnumerable<object[]>> TaskTestData;
    public static Task<IAsyncEnumerable<object[]>> AsyncTaskTestData;
    public static ValueTask<IEnumerable<object[]>> ValueTaskTestData;
    public static ValueTask<IAsyncEnumerable<object[]>> AsyncValueTaskTestData;

    [Theory]
    // For v2, the only fixer offered should be to convert to IEnumerable<object[]>
    // For v3, it should also offer a fixer to convert to IEnumerable<ITheoryDataRow>
    [MemberData(nameof(TestData))]
    // These four should trigger for v2, but not for v3 (since it supports async data members)
    [MemberData(nameof(TaskTestData))]
    [MemberData(nameof(AsyncTaskTestData))]
    [MemberData(nameof(ValueTaskTestData))]
    [MemberData(nameof(AsyncValueTaskTestData))]
    public void TestMethod(string _1, int _2) { }

#if XUNIT_V3

    public static List<ITheoryDataRow> TheoryDataRowData;

    // These should not trigger for v3
    [Theory]
    [MemberData(nameof(TheoryDataRowData))]
    public void SkippedDataRow(int _1, string _2) { }

#endif
}
