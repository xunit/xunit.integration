using System;
using System.Collections.Generic;
using Xunit.Abstractions;

// This can only be auto-fixed in v2-execution or v2-full because it needs the reference to xunit.execution.{platform}
public class xUnit3000 : ITestCase
{
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

    public void Deserialize(IXunitSerializationInfo info) =>
        throw new NotImplementedException();

    public void Serialize(IXunitSerializationInfo info) =>
        throw new NotImplementedException();
}
