#pragma warning disable xUnit1044  // Tuples are not serializable
#pragma warning disable xUnit1046  // Tuples are not serializable

using System.Collections.Generic;
using Xunit;

public class xUnit1039
{
    public static TheoryData<int> FieldData =
        new() { 1, 2, 3 };

    public static TheoryData<int> PropertyData =>
        new() { 1, 2, 3 };

    public static TheoryData<int> MethodDataNoArgs() =>
        new() { 1, 2, 3 };

    public static TheoryData<int> MethodDataWithArgs(int n) =>
        new() { 1, 2, 3, n };

#if XUNIT_V3

    public static IEnumerable<TheoryDataRow<int>> FieldRowData =
        [new(1), new(2), new(3)];

    public static IEnumerable<TheoryDataRow<int>> PropertyRowData =>
        [new(1), new(2), new(3)];

    public static IEnumerable<TheoryDataRow<int>> MethodRowDataNoArgs() =>
        [new(1), new(2), new(3)];

    public static IEnumerable<TheoryDataRow<int>> MethodRowDataWithArgs(int n) =>
        [new(1), new(2), new(3)];

#endif

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
#if XUNIT_V3
    [MemberData(nameof(FieldRowData))]
    [MemberData(nameof(PropertyRowData))]
    [MemberData(nameof(MethodRowDataNoArgs))]
    [MemberData(nameof(MethodRowDataWithArgs), 42)]
#endif
    public void TestMethod(string _) { }

    // Should not be reported despite tuple member names mismatching

    public static TheoryData<(string, string)> UnnamedTupleData =>
        new() { ("Hello", "world") };

    public static TheoryData<(string baz, string biff)> MisnamedTupleData =>
        new() { ("Hello", "world") };

#if XUNIT_V3

    public static IEnumerable<TheoryDataRow<(string, string)>> UnnamedTupleDataRow =>
        [new(("Hello", "world"))];

    public static IEnumerable<TheoryDataRow<(string baz, string biff)>> MisnamedTupleDataRow =>
        [new(("Hello", "world"))];

#endif

    [Theory]
    [MemberData(nameof(UnnamedTupleData))]
    [MemberData(nameof(MisnamedTupleData))]
#if XUNIT_V3
    [MemberData(nameof(UnnamedTupleDataRow))]
    [MemberData(nameof(MisnamedTupleDataRow))]
#endif
    public void TupleTestMethod((string foo, string bar) _) { }
}
