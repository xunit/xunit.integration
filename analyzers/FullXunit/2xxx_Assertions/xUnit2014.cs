using System;
using System.Threading.Tasks;
using Xunit;

public class xUnit2014
{
    class MyMath
    {
        public static Task<int> Divide(params int[] values) => 42;
    }

    [Fact]
    public void TestMethod()
    {
        Assert.Throws<DivideByZeroException>(() => MyMath.Divide(1, 0));
    }
}
