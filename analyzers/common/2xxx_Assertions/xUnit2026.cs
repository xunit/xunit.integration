using System;
using System.Collections.Generic;
using Xunit;

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }
}

public class xUnit2026
{
    [Fact]
    public void TestMethod()
    {
        var set1 = new HashSet<Person> { new("Brad", "Wilson") };
        var set2 = new HashSet<Person> { new("BRAD", "WILSON") };

        Assert.Equal(set1, set2,
            (Person x, Person y) =>
                x.FirstName.Equals(y.FirstName, StringComparison.CurrentCultureIgnoreCase) &&
                x.LastName.Equals(y.LastName, StringComparison.CurrentCultureIgnoreCase)
        );
    }
}
