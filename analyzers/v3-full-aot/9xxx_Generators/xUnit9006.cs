using Xunit;

public class xUnit9006
{
    public static bool AlwaysTrue => true;

    [Fact(Skip = "Don't run", SkipWhen = nameof(AlwaysTrue), SkipUnless = nameof(AlwaysTrue))]
    public void Fact()
    { }

    [Theory]
    [InlineData(42, Skip = "Don't run", SkipWhen = nameof(AlwaysTrue), SkipUnless = nameof(AlwaysTrue))]
    public void Data(int _)
    { }
}
