using System.Collections.Generic;
using Xunit;

public class xUnit1038
{
    public static TheoryData<int, string> FieldData =
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int, string> PropertyData =>
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int, string> MethodDataNoArgs() =>
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int, string> MethodDataWithArgs(int _) =>
        new() { { 1, "Hello" }, { 2, "World" } };

#if XUNIT_V3

    public static IEnumerable<TheoryDataRow<int, string>> FieldRowData =
        [new(1, "Hello"), new(2, "World")];

    public static IEnumerable<TheoryDataRow<int, string>> PropertyRowData =>
        [new(1, "Hello"), new(2, "World")];

    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataNoArgs() =>
        [new(1, "Hello"), new(2, "World")];

    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataWithArgs(int _) =>
        [new(1, "Hello"), new(2, "World")];

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
    public void TestMethod(int _) { }
}
