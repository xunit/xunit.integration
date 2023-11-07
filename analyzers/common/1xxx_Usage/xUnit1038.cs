using Xunit;

public class xUnit1038
{
    public static TheoryData<int?, string?> FieldData =
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int?, string?> PropertyData =>
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int?, string?> MethodDataNoArgs() =>
        new() { { 1, "Hello" }, { 2, "World" } };

    public static TheoryData<int?, string?> MethodDataWithArgs(int _) =>
        new() { { 1, "Hello" }, { 2, "World" } };

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
    public void TestMethod(int _) { }
}
