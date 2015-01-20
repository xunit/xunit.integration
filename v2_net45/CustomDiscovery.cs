using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using Xunit.Serialization;

public class ApplicationTestDiscoverer : IXunitTestCaseDiscoverer
{
    public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
    {
        yield return new SkipTestCase(discoveryOptions.MethodDisplay(), testMethod, "Environment variables are not set for this test - set OCTOKIT_CLIENTID and OCTOKIT_CLIENTSECRET");
    }
}

[XunitTestCaseDiscoverer("ApplicationTestDiscoverer", "v2_net45")]
public class ApplicationTestAttribute : FactAttribute
{
}

[Serializable]
public class SkipTestCase : XunitTestCase
{
    public SkipTestCase(TestMethodDisplay defaultTestMethodDisplay, ITestMethod testMethod, string skipReason)
        : base(defaultTestMethodDisplay, testMethod)
    {
        SkipReason = skipReason;
    }

    protected SkipTestCase(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        SkipReason = info.GetString("SkipReason");
    }

    public override void GetData(XunitSerializationInfo data)
    {
        data.AddValue("SkipReason", SkipReason);

        base.GetData(data);
    }

    [SecurityCritical]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("SkipReason", SkipReason);

        base.GetObjectData(info, context);
    }

    public override void SetData(XunitSerializationInfo data)
    {
        SkipReason = data.GetString("SkipReason");

        base.SetData(data);
    }
}

public class CustomSkipper
{
    [ApplicationTest]
    public void ThisShouldNeverRun()
    {
        Assert.True(false);
    }
}