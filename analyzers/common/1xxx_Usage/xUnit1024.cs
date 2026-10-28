#pragma warning disable xUnit1013 // Public method should be marked as test

using Xunit;

public class xUnit1024 : AbstractClass, IHaveDefaultMethods
{
    [Fact]
    public void TestMethod() { }

    public void TestMethod(int age) { }

    public override void AbstractTestMethod() { }

    public void OverloadOfDefaultNotSupported() { }

    [Fact]
    public void NonDefaultInterfaceMethodsSupported() { }
}

public abstract class AbstractClass
{
    [Fact]
    public abstract void AbstractTestMethod();
}

public interface IHaveDefaultMethods
{
#if NETCOREAPP  // Default interface methods are not supported on .NET Framework
    [Fact]
    public void OverloadOfDefaultNotSupported() { }
#endif

    void NonDefaultInterfaceMethodsSupported();
}
