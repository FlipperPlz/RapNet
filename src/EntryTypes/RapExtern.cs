using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using RapNet.generated;
using RapNet.IO;

namespace RapNet.EntryTypes;
/// <summary>
/// Represents raP entry 'extern'.
/// </summary>
internal sealed class RapExtern : IBinarizedRapEntry
{
    /// <summary>
    /// Extern class reference name.
    /// </summary>
    private string? Name { get; init; }

    /// <summary>
    /// Converts raP entry in to a <see cref="IRapEntry"/> object.
    /// </summary>
    /// <param name="reader">Reader used for reading entry.</param>
    /// <param name="parent">Used for reading arrays recursive.</param>
    /// <returns>Returns a <see cref="IRapEntry"/> object.</returns>
    public IRapEntry FromBinary(RapBinaryReader reader, bool parent = false) => new RapExtern
    {
        Name = reader.ReadAsciiZ()
    };

    /// <summary>
    /// Converts object to human-readable config format.
    /// </summary>
    /// <returns>Returns object as human-readable config format.</returns>
    public string ToConfigFormat() => new StringBuilder("/*external*/ class ").Append(Name ?? throw new NullReferenceException()).Append(';').ToString();

    public IRapEntry FromParseContext(ParserRuleContext ctx) {
        if (ctx is not PoseidonParser.ClassDefinitionContext) throw new Exception();
        var classCtx = (PoseidonParser.ClassDefinitionContext) ctx;
        if (classCtx.classBlock() is not null) throw new Exception("RapExtern was called, I was expecting RapClass so I fucking crashed.");
        if (classCtx.identifier() is null) throw new Exception("No classname was found/specified in the current context.");
        return new RapExtern() {
            Name = classCtx.Start.InputStream.GetText(new Interval(classCtx.identifier().Start.StartIndex, 
                classCtx.identifier().Stop.StopIndex))
        };
    }
}