#pragma warning disable xUnit1013 // Public method should be marked as test

using System.Threading.Tasks;
using Xunit;

public class xUnit1031
{
    [Fact]
    public void TestMethod_Task()
    {
        Task task = Task.FromResult(0);

        task.GetAwaiter().GetResult();
        task.Wait();
        Task.WaitAny(task);
        Task.WaitAll(task);
    }

    [Fact]
    public void TestMethod_TaskOfT()
    {
        Task<int> task = Task.FromResult(0);

        task.GetAwaiter().GetResult();
        task.Wait();
        Task.WaitAny(task);
        Task.WaitAll(task);
    }

    [Fact]
    public void TestMethod_ValueTask()
    {
        ValueTask task = default;

        task.GetAwaiter().GetResult();
    }

    [Fact]
    public void TestMethod_ValueTaskOfT()
    {
        ValueTask<int> task = new(0);

        task.GetAwaiter().GetResult();
    }

    public class MyFactAttribute : FactAttribute { }

    [MyFact]
    public void TestMethod_Ignored()
    {
        var _ = Task.FromResult(0).GetAwaiter().GetResult();
    }

    public void NonTestMethod()
    {
        var _ = Task.FromResult(0).GetAwaiter().GetResult();
    }
}
