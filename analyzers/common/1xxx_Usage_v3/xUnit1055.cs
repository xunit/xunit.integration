using Xunit;

public class xUnit1055
{
    public static bool AlwaysTrue => true;

    [Fact(SkipUnless = nameof(AlwaysTrue), SkipWhen = nameof(AlwaysTrue))]
    public void FactMethod() { }

    [Theory]
    [InlineData(42, SkipUnless = nameof(AlwaysTrue), SkipWhen = nameof(AlwaysTrue))]
    public void TheoryMethod(int _) { }
}

