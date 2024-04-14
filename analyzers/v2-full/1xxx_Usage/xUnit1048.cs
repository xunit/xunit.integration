using Xunit;

public class xUnit1048
{
    // async void is not allowed
    [Fact]
    public async void TestMethod1() { }

    // non-async void is fine
    [Fact]
    public void TestMethod2() { }
}
