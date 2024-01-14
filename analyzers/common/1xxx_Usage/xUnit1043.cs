using System;
using Xunit;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CustomFactAttribute : FactAttribute
{
    internal CustomFactAttribute() { }
}

public class xUnit1043
{
    [CustomFact]
    public void TestMethod() { }
}
