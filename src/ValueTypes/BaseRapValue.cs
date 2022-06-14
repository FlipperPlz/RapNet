using System;
using Antlr4.Runtime;
using RapNet.EntryTypes;

namespace RapNet.ValueTypes;

internal abstract class BaseRapValue<T> : IRapEntry {
    protected T? Value { get; init; }
    public abstract string ToConfigFormat();
    public IRapEntry FromParseContext(ParserRuleContext ctx) => throw new Exception("BaseRapValue<T>::FromParseContext is not a valid method call");
    
}