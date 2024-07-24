using System;
using Xunit.Sdk;
using Xunit.v3;

public class Xunit3002 : IMessageSink
{
    public bool OnMessage(IMessageSinkMessage message)
    {
        if (message is DiscoveryComplete)
            Console.WriteLine("Discovery is finished!");

        return true;
    }
}
