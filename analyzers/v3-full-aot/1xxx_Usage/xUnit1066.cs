using System.Linq;
using Xunit;

public class xUnit1066
{
    public static TheoryData<int> DataSource(params int[] multipliers) =>
        [multipliers.Aggregate(42, (left, right) => left * right)];

    [Theory]
    [MemberData(nameof(DataSource), 2)]
    public void TestMethod(int _)
    { }
}
