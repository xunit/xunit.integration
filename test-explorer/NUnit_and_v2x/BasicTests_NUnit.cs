using NUnit.Framework;

public class BasicTests_NUnit
{
    [Test]
    public void Passing()
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void Failing()
    {
        Assert.IsTrue(false);
    }
}
