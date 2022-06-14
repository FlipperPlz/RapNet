using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using RapNet.Enums;
using RapNet.generated;
using RapNet.IO;

namespace RapNet.EntryTypes;

/// <inheritdoc />
/// <summary>
/// Represents raP entry 'class'.
/// </summary>
internal sealed class RapClass : IBinarizedRapEntry 
{
    /// <summary>
    /// rap entry name.
    /// </summary>
    internal string? Name { get; set; }

    /// <summary>
    /// Inherited class name.
    /// </summary>
    internal string InheritedClassname { get; set; } = "";

    /// <summary>
    /// Count of entries.
    /// </summary>
    internal int Entries { get; set; } = -1;

    /// <summary>
    /// Start offset in binary file.
    /// </summary>
    internal uint Offset { get; set; }

    /// <summary>
    /// Children class entries.
    /// </summary>
    internal List<RapClass> Classes { get; set; } = new List<RapClass>();

    /// <summary>
    /// Value & Array entries.
    /// </summary>
    internal List<RapValue> Values { get; set; } = new List<RapValue>();

    /// <summary>
    /// Extern class entries.
    /// </summary>
    internal List<RapExtern> ExternalClasses { get; set; } = new List<RapExtern>();

    /// <summary>
    /// Delete class entries.
    /// </summary>
    internal List<RapDelete> DeleteStatements { get; set; } = new List<RapDelete>();

    /// <summary>
    /// Converts raP entry in to a IRapEntry object.
    /// </summary>
    /// <param name="reader">Reader used for reading entry.</param>
    /// <param name="parent">Used for reading arrays recursive.</param>
    /// <returns>Returns a IRapEntry object.</returns>
    public IRapEntry FromBinary(RapBinaryReader reader, bool parent = false) => new RapClass 
    {
        Name = reader.ReadAsciiZ(),
        Offset = reader.ReadUint()
    };

    public IRapEntry FromParseContext(ParserRuleContext ctx) 
    {
        if (ctx is not PoseidonParser.ClassDefinitionContext) throw new Exception();
        var classCtx = (PoseidonParser.ClassDefinitionContext) ctx;
        var output = new RapClass();

        if (classCtx.identifier() is not null) {
            output.Name = ctx.Start.InputStream.GetText(new Interval(classCtx.identifier().Start.StartIndex,
                classCtx.identifier().Stop.StopIndex));
        }

        if (classCtx.classExtension() is not null) {
            output.Name = ctx.Start.InputStream.GetText(new Interval(classCtx.classExtension().identifier().Start.StartIndex,
                classCtx.classExtension().identifier().Stop.StopIndex));        
        }

        if (classCtx.classBlock().classDefinition() is { } innerClassContexts) {
            foreach (var innerClassCtx in innerClassContexts) {
                output.Classes.Add(new RapClass().FromParseContext(innerClassCtx) as RapClass ?? throw new Exception());
            }
        }

        if (classCtx.classBlock().statement() is { } statementContexts) {
            foreach (var statementCtx in statementContexts) {
                if (statementCtx.deleteStatement() is { } deleteStatement) {
                    output.DeleteStatements.Add(new RapDelete().FromParseContext(deleteStatement) as RapDelete ?? throw new Exception());
                }

                if (statementCtx.variableAssignment() is { } assignmentContext) {
                    output.Values.Add(new RapValue().FromParseContext(assignmentContext) as RapValue ?? throw new Exception());
                }
            }
        }

        return output;
    }
    
    /// <summary>
    /// Adds an IRapEntry to entry collection based on Type.
    /// </summary>
    /// <param name="entry">Entry to be added.</param>
    /// <param name="reader">Reader for reading binarized rap entry.</param>
    internal void AddEntry(IRapEntry entry, RapBinaryReader reader) 
    {
        switch (entry) {
            case RapClass:
                Classes.Add(reader.ReadBinarizedRapEntry<RapClass>());
                break;
            case RapExtern:
                ExternalClasses.Add(reader.ReadBinarizedRapEntry<RapExtern>());
                break;
            case RapDelete:
                DeleteStatements.Add(reader.ReadBinarizedRapEntry<RapDelete>());
                break;
            case RapValue val:
                if (val.SubType == RapValueType.Array) {
                    Values.Add(reader.ReadBinarizedRapEntry<RapValue>(true));
                    break;
                }

                Values.Add(reader.ReadBinarizedRapEntry<RapValue>());
                break;
            default: throw new Exception("How did we get here?");
        }
    }

    /// <summary>
    /// Converts object to human-readable config format.
    /// </summary>
    /// <returns>Returns object as human-readable config format.</returns>
    public string ToConfigFormat() 
    {
        var builder = new StringBuilder("class ").Append(Name ?? throw new NullReferenceException());
        return InheritedClassname.Length == 0
            ? builder.Append(" {").ToString()
            : builder.Append(" : ").Append(InheritedClassname).Append(" {").ToString();
    }
}