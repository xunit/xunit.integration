using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Xunit.Runner.Common;
using Xunit.Sdk;

public class xUnit3001 : IXunitSerializable
{
    // Need at least one ctor so the auto-generated ctor doesn't satisfy the rule
    public xUnit3001(int _) { }

    public void Deserialize(IXunitSerializationInfo info) { }

    public void Serialize(IXunitSerializationInfo info) { }
}

[JsonTypeID("json-type")]
public class xUnit3001Json : IJsonSerializable, IJsonDeserializable
{
    // Need at least one ctor so the auto-generated ctor doesn't satisfy the rule
    public xUnit3001Json(int _) { }

    public void FromJson(IReadOnlyDictionary<string, object?> root) { }

    public string? ToJson() => "{}";
}

public class xUnit3001Serializer : IXunitSerializer
{
    // Need at least one ctor so the auto-generated ctor doesn't satisfy the rule
    public xUnit3001Serializer(int _) { }

    public object Deserialize(Type type, string serializedValue) => new();

    public bool IsSerializable(Type type, object? value, [NotNullWhen(false)] out string? failureReason)
    {
        failureReason = null;
        return true;
    }

    public string Serialize(object value) => string.Empty;
}

public class xUnit3001Reporter : IRunnerReporter
{
    // Need at least one ctor so the auto-generated ctor doesn't satisfy the rule
    protected xUnit3001Reporter(int _) { }

    public bool CanBeEnvironmentallyEnabled => false;

    public string Description => string.Empty;

    public bool ForceNoLogo => false;

    public bool IsEnvironmentallyEnabled => false;

    public string? RunnerSwitch => "custom";

    public ValueTask<IRunnerReporterMessageHandler> CreateMessageHandler(
        IRunnerLogger logger,
        IMessageSink? diagnosticMessageSink) =>
            throw new NotImplementedException();
}
