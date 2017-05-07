using Xunit;

public class DuplicateUniqueIDs
{
    [Theory]
    [InlineData(2)]
    [InlineData(2)]
    public void OneWillBeSkipped(int x) { }
}
