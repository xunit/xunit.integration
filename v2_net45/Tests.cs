using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

//public class v2_net45
//{
//    [Fact]
//    public void Passing()
//    {
//    }

//    [Fact]
//    public void Failing()
//    {
//        Assert.True(false);
//    }

//    [Theory]
//    [InlineData(2112)]
//    [InlineData("hello")]
//    [InlineData(null)]
//    public void Theory(object value)
//    {
//        Assert.NotNull(value);
//    }
//}

public class PooFlinger : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

public class MyClass : IClassFixture<PooFlinger>
{
    [Fact]
    public void Passing() { Thread.Sleep(1000); }

    [Fact]
    public void Failing() { Thread.Sleep(1000); Assert.True(false); }
}

