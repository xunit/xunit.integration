#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class xUnit1042
{
    public static IEnumerable<object[]> TestData;
#if XUNIT_V3
    public static IEnumerable<TheoryDataRow> TestDataRows;
    public static Task<IEnumerable<TheoryDataRow>> TestDataRowsViaTask;
    public static ValueTask<IAsyncEnumerable<ITheoryDataRow>> TestDataRowsViaValueTask;
#endif

    [Theory]
    [MemberData(nameof(TestData))]
#if XUNIT_V3
    [MemberData(nameof(TestDataRows))]
    [MemberData(nameof(TestDataRowsViaTask))]
    [MemberData(nameof(TestDataRowsViaValueTask))]
#endif
    public static void TestMethod(int _)
    { }
}
