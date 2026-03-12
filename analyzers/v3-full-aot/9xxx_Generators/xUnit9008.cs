using Xunit;

public class xUnit9008
{
    [CulturedFact([])]
    public void FactMethod()
    { }

    [CulturedTheory([])]
    [InlineData(42)]
    public void TheoryMethod(int _)
    { }
}
