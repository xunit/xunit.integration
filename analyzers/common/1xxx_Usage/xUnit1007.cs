using System.Collections.Generic;
using System.Threading;
using Xunit;

class PlainClass { }

class ClassWithAsyncObjectArray : IAsyncEnumerable<object[]>
{
    public IAsyncEnumerator<object[]> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new System.NotImplementedException();
}

#if XUNIT_V3

class ClassWithTheoryData : IEnumerable<ITheoryDataRow>
{
    public IEnumerator<ITheoryDataRow> GetEnumerator() => throw new System.NotImplementedException();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
}

class ClassWithAsyncTheoryData : IAsyncEnumerable<ITheoryDataRow>
{
    public IAsyncEnumerator<ITheoryDataRow> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new System.NotImplementedException();
}

#endif

public class xUnit1007
{
    [Theory]
    [ClassData(typeof(PlainClass))]
    // This should trigger in v2, but not in v3
    [ClassData(typeof(ClassWithAsyncObjectArray))]
#if XUNIT_V3
    // These should not trigger in V3
    [ClassData(typeof(ClassWithTheoryData))]
    [ClassData(typeof(ClassWithAsyncTheoryData))]
#endif
    public void TestMethod(int _1, string _2)
    { }
}
