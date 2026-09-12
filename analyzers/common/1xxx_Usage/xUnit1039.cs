using Xunit;

#if XUNIT_V3
using System.Collections;
using System.Collections.Generic;
#endif

public class xUnit1039
{
    public static TheoryData<int, string, string> FieldData = [];
    public static TheoryData<int, string, string> PropertyData => [];
    public static TheoryData<int, string, string> MethodDataNoArgs() => [];
    public static TheoryData<int, string, string> MethodDataWithArgs(int n) => [];

#if XUNIT_V3

    public class ClassRowData : IEnumerable<TheoryDataRow<string, int, string>>
    {
        public IEnumerator<TheoryDataRow<string, int, string>> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<string, int, string>> FieldRowData = [];
    public static IEnumerable<TheoryDataRow<string, int, string>> PropertyRowData => [];
    public static IEnumerable<TheoryDataRow<string, int, string>> MethodRowDataNoArgs() => [];
    public static IEnumerable<TheoryDataRow<string, int, string>> MethodRowDataWithArgs(int n) => [];

    public class ClassTupleData : IEnumerable<(string, string, int)>
    {
        public IEnumerator<(string, string, int)> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }

    public static IEnumerable<(string, string, int)> FieldTupleData = [];
    public static IEnumerable<(string, string, int)> PropertyTupleData => [];
    public static IEnumerable<(string, string, int)> MethodTupleDataNoArgs() => [];
    public static IEnumerable<(string, string, int)> MethodTupleDataWithArgs(int n) => [];

#endif

    [Theory]
    // Trigger parameter 1
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
#if XUNIT_V3
    // Trigger parameter 2
    [ClassData(typeof(ClassRowData))]
    [MemberData(nameof(FieldRowData))]
    [MemberData(nameof(PropertyRowData))]
    [MemberData(nameof(MethodRowDataNoArgs))]
    [MemberData(nameof(MethodRowDataWithArgs), 42)]
    // Trigger parameter 3
    [ClassData<ClassTupleData>]
    [MemberData(nameof(FieldTupleData))]
    [MemberData(nameof(PropertyTupleData))]
    [MemberData(nameof(MethodTupleDataNoArgs))]
    [MemberData(nameof(MethodTupleDataWithArgs), 42)]
#endif
    public void TestMethod(string _1, string _2, string _3) { }

    // Should not be reported despite tuple member names mismatching

    public static TheoryData<(string, string)> UnnamedTupleData => [];
    public static TheoryData<(string baz, string biff)> MisnamedTupleData => [];

#if XUNIT_V3

    public static IEnumerable<TheoryDataRow<(string, string)>> UnnamedTupleDataRow => [];
    public static IEnumerable<TheoryDataRow<(string baz, string biff)>> MisnamedTupleDataRow => [];

#endif

    [Theory]
    [MemberData(nameof(UnnamedTupleData), DisableDiscoveryEnumeration = true)]   // Tuples are not serializable in v2
    [MemberData(nameof(MisnamedTupleData), DisableDiscoveryEnumeration = true)]  // Tuples are not serializable in v2
#if XUNIT_V3
    [MemberData(nameof(UnnamedTupleDataRow))]
    [MemberData(nameof(MisnamedTupleDataRow))]
#endif
    public void TupleTestMethod((string foo, string bar) _) { }
}
