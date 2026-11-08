using Xunit;

[CollectionDefinition("mispelled")]
public class xUnit1073Collection
{ }

[Collection("misspelled")]
public class xUnit1073
{
    [Fact]
    public void TestMethod() { }
}
