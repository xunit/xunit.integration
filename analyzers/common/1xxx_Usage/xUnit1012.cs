using Xunit;

public class xUnit1012
{
    // nullable struct
    [Theory]
    [InlineData(null)]
    public void TestMethod1a(int _) { }

    // nullable reference type
    [Theory]
    [InlineData(null)]
    public void TestMethod1b(string _) { }

#nullable disable

    // nullable struct unaffected by disabling nullable reference types
    [Theory]
    [InlineData(null)]
    public void TestMethod2a(int _) { }

    // reference type won't trigger with nullable reference types disabled
    [Theory]
    [InlineData(null)]
    public void TestMethod2b(string _) { }
}
