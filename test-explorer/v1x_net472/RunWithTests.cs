using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;

[RunWith(typeof(MyTestClassCommand))]
public class RunWithTests
{
    [MyFact]
    public void Passing() { }
}

public class MyFactAttribute : Attribute { }

public class MyTestCommand : TestCommand
{
    private readonly IMethodInfo method;

    public MyTestCommand(IMethodInfo method, string displayName, int timeout)
        : base(method, displayName, timeout)
    {
        this.method = method;
    }

    public override MethodResult Execute(object testClass)
    {
        try
        {
            throw new DivideByZeroException();
        }
        catch (Exception ex)
        {
            return new FailedResult(method, ex, "Let's do something different here");
        }
    }
}

public class MyTestClassCommand : ITestClassCommand
{
    public int ChooseNextTest(ICollection<IMethodInfo> testsLeftToRun)
    {
        return 0;
    }

    public Exception ClassFinish()
    {
        return null;
    }

    public Exception ClassStart()
    {
        return null;
    }

    public IEnumerable<ITestCommand> EnumerateTestCommands(IMethodInfo testMethod)
    {
        var myFact = testMethod.GetCustomAttributes(typeof(MyFactAttribute)).FirstOrDefault();
        if (myFact != null)
            yield return new MyTestCommand(testMethod, "Hello from MyTestClassCommand!", 0);
    }

    public IEnumerable<IMethodInfo> EnumerateTestMethods()
    {
        foreach (var method in TypeUnderTest.GetMethods())
            if (IsTestMethod(method))
                yield return method;
    }

    public bool IsTestMethod(IMethodInfo testMethod)
    {
        var myFact = testMethod.GetCustomAttributes(typeof(MyFactAttribute)).FirstOrDefault();
        return (myFact != null);
    }

    public object ObjectUnderTest
    {
        get { return null; }
    }

    public ITypeInfo TypeUnderTest { get; set; }
}
