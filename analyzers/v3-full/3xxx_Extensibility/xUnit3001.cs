using System.Collections.Generic;
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

    public string ToJson() => "{}";
}
