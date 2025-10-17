namespace Lamp;

public sealed class CommandApp : ICommandApp
{
    public void Configure(Action<IConfigurator> configuration)
    {
        throw new NotSupportedException();
    }

    public int Run(IEnumerable<string> args, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException();
    }

    public Task<int> RunAsync(IEnumerable<string> args, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException();
    }
}

public sealed class CommandApp<TDefaultCommand> : ICommandApp
    where TDefaultCommand : class, ICommand
{
    public void Configure(Action<IConfigurator> configuration)
    {
        throw new NotSupportedException();
    }

    public int Run(IEnumerable<string> args, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException();
    }

    public Task<int> RunAsync(IEnumerable<string> args, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException();
    }

    public CommandApp<TDefaultCommand> WithDescription(string description)
    {
        throw new NotSupportedException();
    }

    public CommandApp<TDefaultCommand> WithData(object data)
    {
        throw new NotSupportedException();
    }
}