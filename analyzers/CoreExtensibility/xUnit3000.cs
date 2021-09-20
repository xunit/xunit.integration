using System;
using System.Collections.Generic;
using Xunit.Abstractions;

// This version cannot be auto-fixed without an xunit.execution.* reference
public class xUnit3000 : ITestCase
{
    [Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
    public xUnit3000() { }

    public string DisplayName =>
        throw new NotImplementedException();

    public string SkipReason =>
        throw new NotImplementedException();

    public ISourceInformation SourceInformation
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public ITestMethod TestMethod =>
        throw new NotImplementedException();

    public object[] TestMethodArguments =>
        throw new NotImplementedException();

    public Dictionary<string, List<string>> Traits =>
        throw new NotImplementedException();

    public string UniqueID =>
        throw new NotImplementedException();

    public void Deserialize(IXunitSerializationInfo info)
    {
        throw new NotImplementedException();
    }

    public void Serialize(IXunitSerializationInfo info)
    {
        throw new NotImplementedException();
    }
}
