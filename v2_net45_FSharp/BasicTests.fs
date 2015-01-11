namespace FSharp

open Xunit

type BasicTests() =
    [<Fact>]
    member x.Passing() =
        Assert.True(true)

    [<Fact>]
    member x.Failing() =
        Assert.True(false)

    [<Theory>]
    [<InlineData("hello")>]
    [<InlineData("")>]
    member x.Theory(value:string) =
        Assert.NotEmpty(value)
