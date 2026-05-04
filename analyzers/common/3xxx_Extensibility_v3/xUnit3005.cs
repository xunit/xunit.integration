using System.Reflection;
using Xunit;
using Xunit.v3;

// Assembly fixtures must have a public parameterless ctor
[assembly: AssemblyFixture(typeof(MyAssemblyFixture))]

// Test frameworks need a single constructor which takes string? for the config filename, or a parameterless ctor
[assembly: TestFramework(typeof(MyTestFramework))]

public class MyAssemblyFixture
{
    public MyAssemblyFixture(int x)
    { }
}

public class MyTestFramework : ITestFramework
{
    public MyTestFramework(int x)
    { }

    public string TestFrameworkDisplayName =>
        throw new System.NotImplementedException();

    public ITestFrameworkDiscoverer GetDiscoverer(Assembly assembly) =>
        throw new System.NotImplementedException();

    public ITestFrameworkExecutor GetExecutor(Assembly assembly) =>
        throw new System.NotImplementedException();

    public void SetTestPipelineStartup(ITestPipelineStartup pipelineStartup) =>
        throw new System.NotImplementedException();
}
