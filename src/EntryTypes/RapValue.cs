using System;
using System.Globalization;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using RapNet.Enums;
using RapNet.generated;
using RapNet.IO;
using RapNet.ValueTypes;

namespace RapNet.EntryTypes;
/// <summary>
/// Represents raP entry 'value'.
/// </summary>
internal sealed class RapValue : IBinarizedRapEntry 
{
    /// <summary>
    /// Tells which type of value this raP entry holds.
    /// </summary>
    internal RapValueType SubType { get; set; }

    /// <summary>
    /// raP entry name.
    /// </summary>
    private string? Name { get; set; }

    /// <summary>
    /// raP entry value
    /// </summary>
    private IRapEntry? Value { get; set; }


    /// <summary>
    /// Converts raP entry in to a <see cref="IRapEntry"/> object.
    /// </summary>
    /// <param name="reader">Reader used for reading entry.</param>
    /// <param name="parent">Used for reading arrays recursive.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <returns>Returns a <see cref="IRapEntry"/> object.</returns>
    public IRapEntry FromBinary(RapBinaryReader reader, bool parent = false) 
    {
        if (parent || SubType == RapValueType.Array) {
            return new RapValue() {
                SubType = RapValueType.Array,
                Name = reader.ReadAsciiZ(),
                Value = reader.ReadRapArray()
            };
        }

        var rapValue = new RapValue {
            SubType = (RapValueType) reader.ReadByte(),
            Name = reader.ReadAsciiZ()
        };

        IRapEntry value = rapValue.SubType switch {
            RapValueType.String => reader.ReadRapString(),
            RapValueType.Variable => reader.ReadRapVariable(),
            RapValueType.Float => reader.ReadRapFloat(),
            RapValueType.Long => reader.ReadRapInt(),
            RapValueType.Array => reader.ReadRapArray(),
            _ => throw new Exception("How did we get here?")
        };

        rapValue.Value = value;
        return rapValue;
    }

    public IRapEntry FromParseContext(ParserRuleContext ctx) {
        if (ctx is not PoseidonParser.VariableAssignmentContext) throw new Exception();
        var assignmentCtx = (PoseidonParser.VariableAssignmentContext) ctx;
        var output = new RapValue();

        if (assignmentCtx.variableDeclaratorId() is { } nameCtx) {
            var name = ctx.Start.InputStream.GetText(new Interval(nameCtx.Start.StartIndex,
                nameCtx.Stop.StopIndex));
            
            if (name.EndsWith("[]")) {
                output.SubType = RapValueType.Array;
                name = name[..^2];
            }

            output.Name = name;
        }

        if (assignmentCtx.arrayInitializer() is { } arrayInitializer) {
            output.SubType = RapValueType.Array;
            var value = new RapArrayValue();
            foreach (var val in arrayInitializer.variableInitializer()) {
                var valAsString = ctx.Start.InputStream.GetText(new Interval(val.Start.StartIndex, val.Stop.StopIndex));
                try {
                    value.Value?.Add(new RapIntegerValue(int.Parse(valAsString)));
                } catch (Exception e) {
                    try {
                        value.Value?.Add(new RapFloatValue((float) Double.Parse(valAsString, NumberStyles.Float)));
                    } catch (Exception exception) {
                        if (val.expression().primaryExpression().literal().literalString() is not null) {
                            value.Value?.Add(new RapStringValue(valAsString));
                        } else {
                            value.Value?.Add(new RapVariableValue(valAsString));
                        }
                    }
                }
            }

            output.Value = value;

            return output;
        }

        else {
            var valAsString = ctx.Start.InputStream.GetText(new Interval(assignmentCtx.expression().Start.StartIndex, assignmentCtx.expression().Stop.StopIndex));
            try {
                output.Value = new RapIntegerValue(int.Parse(valAsString));
                output.SubType = RapValueType.Long;
                return output;
            } catch (Exception e) {
                try {
                    output.Value = new RapFloatValue((float) Double.Parse(valAsString, NumberStyles.Float));
                    output.SubType = RapValueType.Float;
                    return output;
                } catch (Exception exception) {
                    if (assignmentCtx.expression().primaryExpression().literal().literalString() is not null) {
                        output.Value = new RapStringValue(valAsString);
                        output.SubType = RapValueType.String;
                        return output;
                    } else {
                        output.Value = new RapVariableValue(valAsString);
                        output.SubType = RapValueType.Variable;
                        return output;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Converts object to human-readable config format.
    /// </summary>
    /// <returns>Returns object as human-readable config format.</returns>
    public string ToConfigFormat() 
    { 
        var builder = new StringBuilder(Name);
        var value = Value ?? throw new NullReferenceException();
        if (SubType == RapValueType.Array) builder.Append("[]");
        return builder.Append(" = ").Append(value.ToConfigFormat()).Append(';').ToString();
    }
}
