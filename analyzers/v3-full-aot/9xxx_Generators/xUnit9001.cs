#pragma warning disable CS9113

using Xunit;
using Xunit.v3;

// Test collection factories must implement ICodeGenTestCollectionFactory
[assembly: CollectionBehavior(typeof(MyTestCollectionFactory))]

class MyTestCollectionFactory(ICodeGenTestAssembly testAssembly)
{ }
