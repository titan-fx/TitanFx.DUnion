// #DEFINE DUNION_OMIT_ATTRIBUTES
namespace TitanFx.DUnion
{
    sealed class DUnionAttribute : Attribute { }
}

namespace TestCases
{
    using TitanFx.DUnion;

    public class MyClass
    {
        [DUnion]
        public object Union;
    }
}
