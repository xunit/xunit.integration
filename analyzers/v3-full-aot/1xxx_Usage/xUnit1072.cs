using Reference;
using Xunit;

// This only triggers with AOT and with a binary reference, and requires unloading the
// "reference" project from Visual Studio (after building it) so that it can't find the source code.

public class xUnit1072 : FactBase
{
    [Fact]
    public void LocalTestMethod() { }
}
