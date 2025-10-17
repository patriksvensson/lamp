namespace Lamp;

public sealed class CommandContext
{
    public IReadOnlyList<string> Arguments { get; }
    public string CommandName { get; }
    public object? Data { get; }

    public CommandContext(
        IEnumerable<string> arguments,
        string name,
        object? data)
    {
        Arguments = arguments.ToSafeReadOnlyList();
        CommandName = name ?? throw new ArgumentNullException(nameof(name));
        Data = data;
    }
}