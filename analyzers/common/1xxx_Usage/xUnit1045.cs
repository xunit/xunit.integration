using System;
using Xunit;

public class xUnit1045
{
    public static TheoryData<IDisposable> DataSource = new TheoryData<IDisposable>();

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(IDisposable _) { }
}
