using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using RapNet.generated;
using RapNet.IO;

namespace RapNet.EntryTypes;
/// <inheritdoc />
/// <summary>
/// Represents raP entry 'delete'.
/// </summary>
internal sealed class RapDelete : IBinarizedRapEntry
{
    /// <summary>
    /// Entry name.
    /// </summary>
    private string? Name { get; set; }

    /// <summary>
    /// Converts raP entry in to a IRapEntry object.
    /// </summary>
    /// <param name="reader">Reader used for reading entry.</param>
    /// <param name="parent">Used for reading arrays recursive.</param>
    /// <returns>Returns a IRapEntry object.</returns>
    public IRapEntry FromBinary(RapBinaryReader reader, bool parent = false) => new RapDelete
    {
        Name = reader.ReadAsciiZ()
    };

    /// <summary>
    /// Converts object to human-readable config format.
    /// </summary>
    /// <returns>Returns object as human-readable config format.</returns>
    public string ToConfigFormat() => new StringBuilder("delete /*class*/ ").Append(Name ?? throw new NullReferenceException()).Append(';').ToString();

    public IRapEntry FromParseContext(ParserRuleContext ctx) 
    {
        if (ctx is not PoseidonParser.DeleteStatementContext) throw new Exception("Expecting delete statement, got some other shit instead.");
        var delCtx = (PoseidonParser.DeleteStatementContext) ctx;
        
        if (delCtx.expression() is null) throw new Exception("Delete was called without any expression.");
        return new RapDelete() {
            Name = ctx.Start.InputStream.GetText(new Interval(delCtx.expression().Start.StartIndex,
                delCtx.expression().Stop.StopIndex))
        };
    }
}

