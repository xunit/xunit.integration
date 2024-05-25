using System.Collections.Generic;
using Xunit;

public class xUnit1046
{
    public sealed class NonSerializable { }

    public IEnumerable<TheoryDataRow> Method()
    {
        yield return new TheoryDataRow(new NonSerializable());
    }
}
