#pragma warning disable xUnit1013 // Public method should be marked as test

using System;
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

        // Shouldn't trigger in lambda or local function
        Action _ = () => task.Wait();
        void LocalFunction() => task.Wait();
    }

    [Fact]
    public void TestMethod_TaskOfT()
    {
        Task<int> task = Task.FromResult(0);

        task.GetAwaiter().GetResult();
        task.Wait();
        Task.WaitAny(task);
        Task.WaitAll(task);

        // Shouldn't trigger in lambda or local function
        Action _ = () => task.Wait();
        void LocalFunction() => task.Wait();
    }

    [Fact]
    public void TestMethod_ValueTask()
    {
        ValueTask task = default;

        task.GetAwaiter().GetResult();

        // Shouldn't trigger in lambda or local function
        Action _ = () => task.GetAwaiter().GetResult();
        void LocalFunction() => task.GetAwaiter().GetResult();
    }

    [Fact]
    public void TestMethod_ValueTaskOfT()
    {
        ValueTask<int> task = new(0);

        task.GetAwaiter().GetResult();

        // Shouldn't trigger in lambda or local function
        Action _ = () => task.GetAwaiter().GetResult();
        void LocalFunction() => task.GetAwaiter().GetResult();
    }

    // Ignore test methods which aren't directly Fact/Theory

    public class MyFactAttribute : FactAttribute { }

    [MyFact]
    public void TestMethod_Ignored()
    {
        var _ = Task.FromResult(0).GetAwaiter().GetResult();
    }

    // Ignore non-test methods

    public void NonTestMethod()
    {
        var _ = Task.FromResult(0).GetAwaiter().GetResult();
    }

    // ContinueWith allows you to get access to the task result

    [Fact]
    public async Task ContinueWith_DoesNotTrigger()
    {
        var result = await Task.FromResult(1).ContinueWith(x => x.Result + 2);

        Assert.Equal(3, result);
    }

    // WhenAll allows you to assume all the tasks are safe

    [Fact]
    public async Task WhenAll_DoesNotTrigger()
    {
        var task1 = Task.FromResult(1);
        var task2 = Task.FromResult(2);
        await Task.WhenAll(task1, task2);

        Assert.Equal(3, task1.Result + task2.Result);
    }

    // WhenAny allows you to assume the resulting task is safe

    [Fact]
    public async Task WhenAny_ReturnedTaskDoesNotTrigger()
    {
        var task1 = Task.FromResult(1);
        var task2 = Task.FromResult(2);

        var resultTask = await Task.WhenAny(task1, task2);

        Assert.Equal(42, resultTask.Result);
    }
}
