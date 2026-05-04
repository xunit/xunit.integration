#pragma warning disable CS9113

using Xunit;
using Xunit.v3;

// Test collection factories must implement ICodeGenTestCollectionFactory
[assembly: CollectionBehavior(typeof(MyTestCollectionFactory))]

#if XUNIT_AOT

class MyTestCollectionFactory(ICodeGenTestAssembly testAssembly)
{ }

#else

class MyTestCollectionFactory(IXunitTestAssembly testAssembly)
{ }

#endif

