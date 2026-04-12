#pragma warning disable xUnit1026

using Xunit;

public class xUnit1064
{
    [Theory]
    [InlineData("Hello world", 42)]
    [InlineData("Hello world", 2112, 2600)]
    public void TheoryMethod(string greeting, params int[] values)
    { }

    [CulturedTheory(["en-US"])]
    [InlineData("Hello world", 42)]
    [InlineData("Hello world", 2112, 2600)]
    public void CulturedTheoryMethod(string greeting, params int[] values)
    { }
}
