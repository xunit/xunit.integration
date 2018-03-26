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
#pragma warning disable xUnit1026  // Don't need to use the bad data
    public void TheoryDataSerializerIsBroken(BadTheoryItem item) { }
#pragma warning restore xUnit1026

    public static TheoryData<BadTheoryItem> BadTheoryData = new TheoryData<BadTheoryItem> { new BadTheoryItem(42) };
}

[XunitTestCaseDiscoverer("CustomFactDiscoverer", "v2x_net452")]
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
    // To make xUnit 3001 go away until fixed
    public CustomTestCase()
    {

    }
    // Configuration problem: failed to provide an empty constructor

    public CustomTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, ITestMethod testMethod, object[] testMethodArguments = null)
        : base(diagnosticMessageSink, defaultMethodDisplay, testMethod, testMethodArguments)
    { }
}

public class BadTheoryItem : IXunitSerializable
{
    // To make xUnit 3001 go away until fixed
    public BadTheoryItem()
    {

    }
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