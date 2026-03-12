using Xunit;

public class xUnit1025
{
    [Theory]
    [InlineData(2)]
    [InlineData(2)]
    public void TestMethod(int _)
    { }

    [Theory]
    [InlineData(2, 0)]
    [InlineData(2)]
    public void TestMethod2(int _1, int _2 = 0)
    { }

#if !XUNIT_AOT  // params not supported for test methods in AOT

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(new object[] { 1, 2, 3 })]
    public void TestMethod3(params int[] _)
    { }

#endif
}
