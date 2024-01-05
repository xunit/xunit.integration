using Xunit;

public class xUnit1004
{
    [Fact(Skip = "This is a flaky test")]
    public void TestMethod() { }
}
