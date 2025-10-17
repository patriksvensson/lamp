namespace Lamp;

public interface ICommandApp
{
    void Configure(Action<IConfigurator> configuration);
    int Run(IEnumerable<string> args, CancellationToken cancellationToken = default);
    Task<int> RunAsync(IEnumerable<string> args, CancellationToken cancellationToken = default);
}