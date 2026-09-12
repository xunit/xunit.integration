#pragma warning disable xUnit1045

using System;
using Xunit;

#if XUNIT_V3
using System.Collections;
using System.Collections.Generic;
#endif

public class xUnit1040
{
    public static TheoryData<string?, object, IDisposable> FieldData = [];
    public static TheoryData<string?, object, IDisposable> PropertyData => [];
    public static TheoryData<string?, object, IDisposable> MethodDataNoArgs() => [];
    public static TheoryData<string?, object, IDisposable> MethodDataWithArgs(int _) => [];

#if XUNIT_V3

    public class ClassRowData : IEnumerable<TheoryDataRow<string, object?, IDisposable>>
    {
        public IEnumerator<TheoryDataRow<string, object?, IDisposable>> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    public static IEnumerable<TheoryDataRow<string, object?, IDisposable>> FieldRowData = [];
    public static IEnumerable<TheoryDataRow<string, object?, IDisposable>> PropertyRowData => [];
    public static IEnumerable<TheoryDataRow<string, object?, IDisposable>> MethodRowDataNoArgs() => [];
    public static IEnumerable<TheoryDataRow<string, object?, IDisposable>> MethodRowDataWithArgs(int _) => [];

    public class ClassTupleData : IEnumerable<(string, object, IDisposable?)>
    {
        public IEnumerator<(string, object, IDisposable?)> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    public static IEnumerable<(string, object, IDisposable?)> FieldTupleData = [];
    public static IEnumerable<(string, object, IDisposable?)> PropertyTupleData => [];
    public static IEnumerable<(string, object, IDisposable?)> MethodTupleDataNoArgs() => [];
    public static IEnumerable<(string, object, IDisposable?)> MethodTupleDataWithArgs(int _) => [];

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
    public void TestMethod(string _1, object _2, IDisposable _3) { }
}
