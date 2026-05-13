using System.Collections.Generic;
using TitanFx.DUnion;

namespace TestCases;

[DUnion]
public readonly partial record struct JsonValue
{
    public readonly record struct String(string Value);

    public readonly record struct Number(double Value);

    public readonly record struct Boolean(bool Value);

    public readonly record struct Null();

    public readonly record struct Array(IReadOnlyList<JsonValue> Values);

    public readonly record struct Object(IReadOnlyDictionary<string, JsonValue> Properties);
}
