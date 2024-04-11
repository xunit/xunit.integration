using Xunit;

public class xUnit1044
{
    public sealed class NonSerializable { }

    public static TheoryData<NonSerializable> DataSource = new TheoryData<NonSerializable>();

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(NonSerializable _) { }
}
