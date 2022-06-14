using Antlr4.Runtime;

namespace RapNet.EntryTypes;

/// <summary>
/// Represents raP entry.
/// </summary>
internal interface IRapEntry
{
    /// <summary>
    /// Converts object to human-readable config format.
    /// </summary>
    /// <returns>Returns object as human-readable config format.</returns>
    string ToConfigFormat();
    
    IRapEntry FromParseContext(ParserRuleContext ctx);

}