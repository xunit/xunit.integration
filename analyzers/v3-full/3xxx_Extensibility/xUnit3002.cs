#pragma warning disable xUnit2007

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;
using Xunit.v3;

public class Xunit3002 : IMessageSink
{
    public class GenericClass<T> { }

    public static DiscoveryComplete Factory1() =>
        new() { AssemblyUniqueID = "id", TestCasesToRun = 42 };

    public static DiscoveryComplete Factory2() =>
        new DiscoveryComplete() { AssemblyUniqueID = "id", TestCasesToRun = 42 };

    public bool OnMessage(IMessageSinkMessage message)
    {
        if (message is DiscoveryComplete)
            Console.WriteLine("Discovery is finished!");
        if (message is not DiscoveryComplete)
            Console.WriteLine("Discovery is not finished!");
        if (message is GenericClass<DiscoveryComplete>)
            Console.WriteLine("Discovery is finished!");
        if (message is IEnumerable<DiscoveryComplete>)
            Console.WriteLine("Discovery is finished!");

        Console.WriteLine(message as DiscoveryComplete);
        Console.WriteLine((DiscoveryComplete)message);

        Assert.Empty(Array.Empty<object>().OfType<DiscoveryComplete>());
        Assert.IsType<DiscoveryComplete>(message);
        Assert.IsType(typeof(DiscoveryComplete), message);

        return true;
    }
}
