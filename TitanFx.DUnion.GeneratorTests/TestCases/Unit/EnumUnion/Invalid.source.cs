// #DEFINE DUNION_OMIT_ATTRIBUTES
namespace TitanFx.DUnion
{
    sealed class DUnionAttribute : Attribute { }
}

namespace TestCases
{
    using TitanFx.DUnion;

    [DUnion]
    public enum Union
    {
        A,
        B,
        C,
    }
}
