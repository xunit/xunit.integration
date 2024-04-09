using Xunit;

public abstract class xUnit1013_Base
{
    [Fact]
    public abstract void TestMethod4();
}

public class xUnit1013 : xUnit1013_Base
{
    [Fact]
    public void TestMethod1() { }

    // The fixer should offer to convert this to a Fact, because it has no parameters
    public void TestMethod2() { }

    // The fixer should offer to convert this to a Theory, because it has parameters
    public void TestMethod3(int _) { }

    // This should not trigger because the [Fact] comes from the base class
    public override void TestMethod4() { }
}
