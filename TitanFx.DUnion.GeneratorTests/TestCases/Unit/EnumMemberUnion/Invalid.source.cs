// #DEFINE DUNION_OMIT_ATTRIBUTES
namespace TitanFx.DUnion
{
    sealed class DUnionAttribute : Attribute { }
}

namespace TestCases
{
    using TitanFx.DUnion;

    public enum MyEnums
    {
        [DUnion]
        Union,
        B,
        C,
    }
}
