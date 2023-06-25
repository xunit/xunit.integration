using Xunit;

public class MyFixture { }

public class xUnit1033 : IClassFixture<MyFixture>
{
    [Fact]
    public void TestMethod() { }
}
