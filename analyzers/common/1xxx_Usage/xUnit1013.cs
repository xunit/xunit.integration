using Xunit;

public class xUnit1013
{
    [Fact]
    public void TestMethod1() { }

    // The fixer should offer to convert this to a Fact, because it has no parameters
    public void TestMethod2() { }

    // The fixer should offer to convert this to a Theory, because it has parameters
    public void TestMethod3(int _) { }
}
