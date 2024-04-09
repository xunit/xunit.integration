using System.Collections.Generic;
using Xunit.Sdk;

public class xUnit1046
{
    public sealed class NonSerializable { }

    public IEnumerable<TheoryDataRow> Method()
    {
        yield return new TheoryDataRow(new NonSerializable());
    }
}
