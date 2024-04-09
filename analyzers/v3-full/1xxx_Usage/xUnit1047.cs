using System.Collections.Generic;
using Xunit.Sdk;

public class xUnit1047
{
    public class MaybeSerializable { }

    public IEnumerable<TheoryDataRow> Method()
    {
        yield return new TheoryDataRow(default(MaybeSerializable));
    }
}
