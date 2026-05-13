// #DEFINE DUNION_OMIT_ATTRIBUTES
namespace TitanFx.DUnion
{
    sealed class DUnionAttribute : Attribute { }
}

namespace TestCases
{
    using TitanFx.DUnion;

    [DUnion]
    public interface Union
    {
        public class Case1 { }

        public class Case2 { }
    }
}
