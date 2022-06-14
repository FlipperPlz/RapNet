using System;
using System.Text;
using Antlr4.Runtime;
using RapNet.EntryTypes;

namespace RapNet.Preprocessors;
/// <summary>
/// Represents a config preprocessor define. (#define [name] [value])
/// </summary>
internal sealed class RapDefinePreprocessor : IRapEntry
{
    /// <summary>
    /// Preprocessor name.
    /// </summary>
    private string Name { get; set; }

    /// <summary>
    /// Preprocessor value.
    /// </summary>
    private int Value { get; set; }

    /// <summary>
    /// Initializes a new instance of the RapDefinePreprocessor class, with name and value.
    /// </summary>
    /// <param name="name">Preprocessor name.</param>
    /// <param name="value">Preprocessor value.</param>
    internal RapDefinePreprocessor(string name, int value)
    {
        Name = name;
        Value = value;
    }

    /// <summary>
    /// Converts object to final config format.
    /// </summary>
    /// <returns>Returns object as final config format.</returns>
    public string ToConfigFormat() => new StringBuilder("#define ").Append(Name).Append(' ').Append(Value).ToString();

    public IRapEntry FromParseContext(ParserRuleContext ctx) => throw new Exception("RapDefine::FromParseContext is not a valid method call.");
}
