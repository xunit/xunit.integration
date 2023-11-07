using Xunit;

public class xUnit1040
{
    public static TheoryData<string?> FieldData =
        new() { "Hello", "World", null };

    public static TheoryData<string?> PropertyData =>
        new() { "Hello", "World", null };

    public static TheoryData<string?> MethodDataNoArgs() =>
        new() { "Hello", "World", null };

    public static TheoryData<string?> MethodDataWithArgs(int _) =>
        new() { "Hello", "World", null };

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
    public void TestMethod(string _) { }
}
