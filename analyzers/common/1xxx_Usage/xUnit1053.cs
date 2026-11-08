#pragma warning disable CS8618

using Xunit;

public class xUnit1053
{
    public static TheoryData<int> DataSource;

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(int x) =>
        Assert.NotEqual(0, x);
}
