using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using CA = Microsoft.CodeAnalysis;

namespace TitanFx.DUnion.Models;

internal record class Location(string FilePath, TextSpan TextSpan, LinePositionSpan LineSpan)
{
    [return: NotNullIfNotNull(nameof(location))]
    public static implicit operator CA.Location?(Location? location)
    {
        if (location is null)
            return null;

        return CA.Location.Create(location.FilePath, location.TextSpan, location.LineSpan);
    }

    [return: NotNullIfNotNull(nameof(location))]
    public static implicit operator Location?(CA.Location? location)
    {
        if (location is null)
            return null;

        if (location is not { SourceTree.FilePath: string filePath })
            throw new ArgumentException("Location must contain a source tree", nameof(location));

        return new(filePath, location.SourceSpan, location.GetLineSpan().Span);
    }
}
