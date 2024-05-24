using Xunit;

#if XUNIT_V3
using System.Collections.Generic;
using System.Threading;
#endif

public class xUnit1037
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

    public class ClassRowData : IAsyncEnumerable<TheoryDataRow<int>>
    {
        public IAsyncEnumerator<TheoryDataRow<int>> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new System.NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<int>> FieldRowData =
        [new(1), new(2), new(3), new(4)];

    public static IEnumerable<TheoryDataRow<int>> PropertyRowData =>
        [new(1), new(2), new(3), new(4)];

    public static IEnumerable<TheoryDataRow<int>> MethodRowDataNoArgs() =>
        [new(1), new(2), new(3), new(4)];

    public static IEnumerable<TheoryDataRow<int>> MethodRowDataWithArgs(int n) =>
        [new(1), new(2), new(3), new(4)];

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
    public void TestMethod(int _1, string _2) { }
}
