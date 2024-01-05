using Xunit;

static class MyGreetingService
{
    public static string Greet(string name) =>
        $"Hello, {name}!";
}

public class xUnit1026
{
    [Theory]
    [InlineData("Joe", 42)]
    public void ValidateGreeting(string name, int age)
    {
        var result = MyGreetingService.Greet(name);

        Assert.Equal("Hello, Joe!", result);
    }
}
