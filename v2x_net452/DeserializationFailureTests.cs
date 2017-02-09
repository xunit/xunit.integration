using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

public class DeserializationFailureTests
{
    [CustomFact]
    public void TestCaseSerializerIsBroken() { }

    [Theory]
    [MemberData(nameof(BadTheoryData))]
    public void TheoryDataSerializerIsBroken(BadTheoryItem item) { }

    public static TheoryData<BadTheoryItem> BadTheoryData = new TheoryData<BadTheoryItem> { new BadTheoryItem(42) };
}

[XunitTestCaseDiscoverer("CustomFactDiscoverer", "v2x_net45")]
class CustomFactAttribute : FactAttribute { }

class CustomFactDiscoverer : IXunitTestCaseDiscoverer
{
    readonly IMessageSink diagnosticMessageSink;

    public CustomFactDiscoverer(IMessageSink diagnosticMessageSink)
    {
        this.diagnosticMessageSink = diagnosticMessageSink;
    }

    public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
    {
        yield return new CustomTestCase(diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), testMethod);
    }
}

class CustomTestCase : XunitTestCase
{
    // Configuration problem: failed to provide an empty constructor

    public CustomTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, ITestMethod testMethod, object[] testMethodArguments = null)
        : base(diagnosticMessageSink, defaultMethodDisplay, testMethod, testMethodArguments)
    { }
}

public class BadTheoryItem : IXunitSerializable
{
    // Configuration problem: failed to provide an empty constructor

    public BadTheoryItem(int value)
    {
        Value = value;
    }

    public int Value { get; private set; }

    public void Deserialize(IXunitSerializationInfo info)
    {
        Value = info.GetValue<int>(nameof(Value));
    }

    public void Serialize(IXunitSerializationInfo info)
    {
        info.AddValue(nameof(Value), Value);
    }
}