namespace FSharp

open Xunit

type BasicTests() =
    [<Fact>]
    member _.Passing() =
        Assert.True true

    [<Fact>]
    member _.Failing() =
        Assert.True false

    [<Theory>]
    [<InlineData("hello from v2x_net472_FSharp")>]
    [<InlineData("")>]
    [<InlineData(null)>]
    member _.Theory(value:string) =
        Assert.NotNull value
