using Xunit;

public class xUnit1004
{
    [Fact(Skip = "This is a flaky test")]
    public void TestMethod() { }

#if XUNIT_V3 && NETCOREAPP

    public static bool IsWindows => System.OperatingSystem.IsWindows();

    // Should not trigger, since it's conditional
    [Fact(Skip = "Requires Windows", SkipUnless = nameof(IsWindows))]
    public void WindowsTest() { }

#endif
}
