using Xunit;

public class xUnit1054
{
    public static TheoryData<int> DataSource = [42, 2112];
    public static int ReturningInt => 42;
    static bool NonPublicBool => true;

    // Fact examples
    [Fact(Skip = "Conditionally Skipped", SkipWhen = "Foo")]
    public void Missing_Fact() { }

    [Fact(Skip = "Conditionally Skipped", SkipUnless = nameof(ReturningInt))]
    public void WrongType_Fact() { }

    [Fact(Skip = "Conditionally Skipped", SkipWhen = nameof(NonPublicBool))]
    public void NonPublic_Fact() { }

    // Data examples
    [Theory]
    [MemberData(nameof(DataSource), Skip = "Conditionally Skipped", SkipUnless = "Foo")]
    public void Missing_Data(int _) { }

    [Theory]
    [MemberData(nameof(DataSource), Skip = "Conditionally Skipped", SkipWhen = nameof(ReturningInt))]
    public void WrongType_Data(int _) { }

    [Theory]
    [MemberData(nameof(DataSource), Skip = "Conditionally Skipped", SkipUnless = nameof(NonPublicBool))]
    public void NonPublic_Data(int _) { }
}
