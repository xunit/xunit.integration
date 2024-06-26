using Xunit;

#if XUNIT_V3
using System.Collections;
using System.Collections.Generic;
#endif

public class xUnit1040
{
    public static TheoryData<string?> FieldData =
        new() { "Hello", "World", default(string) };

    public static TheoryData<string?> PropertyData =>
        new() { "Hello", "World", default(string) };

    public static TheoryData<string?> MethodDataNoArgs() =>
        new() { "Hello", "World", default(string) };

    public static TheoryData<string?> MethodDataWithArgs(int _) =>
        new() { "Hello", "World", default(string) };

#if XUNIT_V3

    public class ClassRowData : IEnumerable<TheoryDataRow<string?>>
    {
        public IEnumerator<TheoryDataRow<string?>> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<string?>> FieldRowData =
        [new("Hello"), new("World"), new(null)];

    public static IEnumerable<TheoryDataRow<string?>> PropertyRowData =>
        [new("Hello"), new("World"), new(null)];

    public static IEnumerable<TheoryDataRow<string?>> MethodRowDataNoArgs() =>
        [new("Hello"), new("World"), new(null)];

    public static IEnumerable<TheoryDataRow<string?>> MethodRowDataWithArgs(int _) =>
        [new("Hello"), new("World"), new(null)];

#endif

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
#if XUNIT_V3
    [ClassData(typeof(ClassRowData))]
    [MemberData(nameof(FieldRowData))]
    [MemberData(nameof(PropertyRowData))]
    [MemberData(nameof(MethodRowDataNoArgs))]
    [MemberData(nameof(MethodRowDataWithArgs), 42)]
#endif
    public void TestMethod(string _) { }
}
