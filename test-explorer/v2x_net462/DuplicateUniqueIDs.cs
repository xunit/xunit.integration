using Xunit;

public class DuplicateUniqueIDs
{
    [Theory]
    [InlineData(2)]
#pragma warning disable xUnit1025  // The purpose is to illustrate duplicates
    [InlineData(2)]
#pragma warning restore xUnit1025
#pragma warning disable xUnit1026  // Don't need to use the bad data
    public void OneWillBeSkipped(int x) { }
#pragma warning restore xUnit1026
}
