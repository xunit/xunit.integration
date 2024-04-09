using System;
using Xunit;

public class xUnit1045
{
    public static TheoryData<IDisposable> DataSource = [];

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(IDisposable _) { }
}
