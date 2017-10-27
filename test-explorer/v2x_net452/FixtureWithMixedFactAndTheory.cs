#pragma warning disable xUnit1026

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Xunit;

public class FixtureWithMixedFactAndTheory : IClassFixture<FixtureWithMixedFactAndTheory.Fixture>
{
    Fixture fixture;

    public FixtureWithMixedFactAndTheory(Fixture fixture)
    {
        this.fixture = fixture;
    }

    [Theory]
    [ClassData(typeof(InlineConfigurations))]
    public void Theory1(ClassConf conf)
    {
        Assert.Equal(1, fixture.ConstructorIteration);
    }

    [Theory]
    [InlineData(42)]
    [InlineData(2112)]
    public void Theory2(int data)
    {
        Assert.Equal(1, fixture.ConstructorIteration);
    }

    [Fact]
    public void Fact1()
    {
        Assert.Equal(1, fixture.ConstructorIteration);
    }

    [Fact]
    public void Fact2()
    {
        Assert.Equal(1, fixture.ConstructorIteration);
    }

    public class ClassConf
    {
        public int Id { get; set; }

        public string Title { get; set; }

    }

    public class Fixture
    {
        public static long StaticConstructorCount = 0L;

        public readonly long ConstructorIteration;

        public Fixture()
        {
            ConstructorIteration = Interlocked.Increment(ref StaticConstructorCount);
        }
    }

    public class InlineConfigurations : IEnumerable<object[]>
    {
        private readonly List<object[]> confs = new List<object[]>();

        public InlineConfigurations()
        {
            confs.Add(new object[] { new ClassConf{
                Id = 100,
                Title = "Title 1"
            } });

            confs.Add(new object[] { new ClassConf{
                Id = 200,
                Title = "Title 2"
            } });

            confs.Add(new object[] { new ClassConf{
                Id = 300,
                Title = "Title 3"
            } });
        }

        public IEnumerator<object[]> GetEnumerator() => confs.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}