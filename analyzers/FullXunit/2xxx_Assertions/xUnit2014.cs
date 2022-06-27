using System;
using System.Threading.Tasks;
using Xunit;

public class xUnit2014
{
    class MyMath
    {
        public static Task<int> Divide(params int[] values) => Task.FromResult(42);
    }

    [Fact]
    public void TestMethod()
    {
        // This will always also show CS0619 because we use [Obsolete(..., error: true)]
        Assert.Throws<DivideByZeroException>(() => MyMath.Divide(1, 0));
    }
}
