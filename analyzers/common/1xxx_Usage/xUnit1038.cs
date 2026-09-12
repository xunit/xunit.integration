using Xunit;

#if XUNIT_V3
using System.Collections;
using System.Collections.Generic;
#endif

public class xUnit1038
{
    public static TheoryData<int, string> FieldData = [];
    public static TheoryData<int, string> PropertyData => [];
    public static TheoryData<int, string> MethodDataNoArgs() => [];
    public static TheoryData<int, string> MethodDataWithArgs(int _) => [];

#if XUNIT_V3

    public class ClassRowData_TheoryDataRow : IEnumerable<TheoryDataRow<int, string>>
    {
        public IEnumerator<TheoryDataRow<int, string>> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }

    public class ClassRowData_Tuple : IEnumerable<TheoryDataRow<int, string>>
    {
        public IEnumerator<TheoryDataRow<int, string>> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<int, string>> FieldRowData_TheoryDataRow = [];
    public static IEnumerable<(int, string)> FieldRowData_Tuple = [];
    public static IEnumerable<TheoryDataRow<int, string>> PropertyRowData_TheoryDataRow => [];
    public static IEnumerable<(int, string)> PropertyRowData_Tuple => [];
    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataNoArgs_TheoryDataRow() => [];
    public static IEnumerable<(int, string)> MethodRowDataNoArgs_Tuple() => [];
    public static IEnumerable<TheoryDataRow<int, string>> MethodRowDataWithArgs_TheoryDataRow(int _) => [];
    public static IEnumerable<(int, string)> MethodRowDataWithArgs_Tuple(int _) => [];

#endif

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
#if XUNIT_V3
    [ClassData(typeof(ClassRowData_TheoryDataRow))]
    [MemberData(nameof(FieldRowData_TheoryDataRow))]
    [MemberData(nameof(PropertyRowData_TheoryDataRow))]
    [MemberData(nameof(MethodRowDataNoArgs_TheoryDataRow))]
    [MemberData(nameof(MethodRowDataWithArgs_TheoryDataRow), 42)]
    [ClassData(typeof(ClassRowData_Tuple))]
    [MemberData(nameof(FieldRowData_Tuple))]
    [MemberData(nameof(PropertyRowData_Tuple))]
    [MemberData(nameof(MethodRowDataNoArgs_Tuple))]
    [MemberData(nameof(MethodRowDataWithArgs_Tuple), 42)]
#endif
    public void TestMethod(int _) { }
}
