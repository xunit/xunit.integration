using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Xunit;

public class xUnit1050
{
    [Theory]
    [ClassData(typeof(EnumerableData))]
    [ClassData(typeof(AsyncEnumerableData))]
    public void TestMethod(int _) { }

    public class EnumerableData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    public class AsyncEnumerableData : IAsyncEnumerable<object[]>
    {
        public IAsyncEnumerator<object[]> GetAsyncEnumerator(CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }
}
