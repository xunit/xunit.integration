using Xunit;

public class xUnit1004
{
    [Fact(Skip = "This is a flaky test")]
    public void TestMethod() { }

#if XUNIT_V3 && NETCOREAPP

    [Fact(Skip = "Requires Windows",
          SkipUnless = nameof(System.OperatingSystem.IsWindows),
          SkipType = typeof(System.OperatingSystem))]
    public void WindowsTest() { }

#endif
}
