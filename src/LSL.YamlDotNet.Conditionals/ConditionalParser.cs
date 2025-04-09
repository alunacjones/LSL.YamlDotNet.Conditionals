using System;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace LSL.YamlDotNet.Conditionals;

public class ConditionalParser : IParser
{
    private readonly Func<string, bool> _evaluator;
    private readonly IParser _innerParser;

    public ConditionalParser(Func<string, bool> evaluator, IParser innerParser)
    {
        _evaluator = evaluator;
        _innerParser = innerParser;
    }

    /// <inheritdoc/>
    public ParsingEvent Current => throw new NotImplementedException();

    /// <inheritdoc/>
    public bool MoveNext()
    {
        throw new NotImplementedException();
    }
}