using Xunit.Abstractions;

public class xUnit3001 : IXunitSerializable
{
    // Need at least one ctor so the auto-generated ctor doesn't satisfy the rule
    public xUnit3001(int _) { }

    public void Deserialize(IXunitSerializationInfo info) { }

    public void Serialize(IXunitSerializationInfo info) { }
}
