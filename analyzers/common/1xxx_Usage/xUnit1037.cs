using Xunit;

public class xUnit1037
{
    public static TheoryData<int> FieldData =
        new() { 1, 2, 3 };

    public static TheoryData<int> PropertyData =>
        new() { 1, 2, 3 };

    public static TheoryData<int> MethodDataNoArgs() =>
        new() { 1, 2, 3 };

    public static TheoryData<int> MethodDataWithArgs(int n) =>
        new() { 1, 2, 3, n };

    [Theory]
    [MemberData(nameof(FieldData))]
    [MemberData(nameof(PropertyData))]
    [MemberData(nameof(MethodDataNoArgs))]
    [MemberData(nameof(MethodDataWithArgs), 42)]
    public void TestMethod(int _1, string _2) { }
}
