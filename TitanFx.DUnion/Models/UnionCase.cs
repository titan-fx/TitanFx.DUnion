namespace TitanFx.DUnion.Models;

internal sealed record UnionCase(TypeId Id, TypeDefinition Definition, UnionCaseConfig Config);
