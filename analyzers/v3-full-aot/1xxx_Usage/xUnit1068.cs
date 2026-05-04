#pragma warning disable xUnit1063

using Xunit;

public class xUnit1068<T>
{
    public static TheoryData<T> Data = [];

    [Theory]
    [MemberData(nameof(Data))]
    public void TestMethod(T _) { }
}
