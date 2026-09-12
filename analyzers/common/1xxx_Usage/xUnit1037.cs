using Xunit;

#if XUNIT_V3
using System;
using System.Collections.Generic;
using System.Threading;
#endif

public class xUnit1037
{
    public static TheoryData<int, string> FieldData = [];
    public static TheoryData<int, string> PropertyData => [];
    public static TheoryData<int, string> MethodDataNoArgs() => [];
    public static TheoryData<int, string> MethodDataWithArgs(int n) => [];

#if XUNIT_V3

    public class ClassRowData_TheoryDataRow : IAsyncEnumerable<TheoryDataRow<int, string>>
    {
        public IAsyncEnumerator<TheoryDataRow<int, string>> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<int, string>> FieldRowData = [];
    public static IEnumerable<TheoryDataRow<int, string>> PropertyRowData => [];
    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataNoArgs() => [];
    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataWithArgs(int n) => [];

    public class ClassRowData_Tuple : IAsyncEnumerable<(int, string)>
    {
        public IAsyncEnumerator<(int, string)> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }

    public static IEnumerable<(int, string)> FieldTupleData = [];
    public static IEnumerable<(int, string)> PropertyTupleData => [];
    public static IEnumerable<(int, string)> MethodTupleDataNoArgs() => [];
    public static IEnumerable<(int, string)> MethodTupleDataWithArgs(int n) => [];

#endif

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
#if XUNIT_V3
    [ClassData(typeof(ClassRowData_TheoryDataRow))]
    [MemberData(nameof(FieldRowData))]
    [MemberData(nameof(PropertyRowData))]
    [MemberData(nameof(MethodRowDataNoArgs))]
    [MemberData(nameof(MethodRowDataWithArgs), 42)]
    [ClassData<ClassRowData_Tuple>]
    [MemberData(nameof(FieldTupleData))]
    [MemberData(nameof(PropertyTupleData))]
    [MemberData(nameof(MethodTupleDataNoArgs))]
    [MemberData(nameof(MethodTupleDataWithArgs), 42)]
#endif
    public void TestMethod(int _1, string _2, double _3) { }
}
