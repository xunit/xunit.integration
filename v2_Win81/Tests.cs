using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

public class v2_Win81
{
    [Fact]
    public void Passing()
    {
    }

    [Fact]
    public void Failing()
    {
        Assert.True(false);
    }

    [Theory]
    [InlineData(21.12)]
    [InlineData("hello")]
    [InlineData(null)]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }

    [Fact]
    public async Task Failing_AsyncTask()
    {
        await Task.Delay(1);
        Assert.True(false);
    }
}
