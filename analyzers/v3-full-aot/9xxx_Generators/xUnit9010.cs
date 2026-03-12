using Xunit;

public class xUnit9010
{
    [Theory]
    [InlineData(42)]
    public void TheoryMethod<T>(T value)
    { }

    [CulturedTheory(["en-US"])]
    [InlineData(42)]
    public void CulturedTheoryMethod<T>(T value)
    { }
}
