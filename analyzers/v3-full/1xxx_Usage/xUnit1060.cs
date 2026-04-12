using Xunit;

public class xUnit1060
{
    [CulturedFact(new string[] { })]
    public void FactMethod()
    { }

    [CulturedTheory([])]
    [InlineData(42)]
    public void TheoryMethod(int _)
    { }
}
