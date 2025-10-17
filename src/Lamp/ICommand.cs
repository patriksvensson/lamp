namespace Lamp;

public interface ICommand
{
    ValidationResult Validate(CommandContext context, CommandSettings settings);
    Task<int> ExecuteAsync(CommandContext context, CommandSettings settings, CancellationToken cancellationToken);
}

public interface ICommand<TSettings> : ICommandLimiter<TSettings>
    where TSettings : CommandSettings
{
    Task<int> ExecuteAsync(CommandContext context, TSettings settings, CancellationToken cancellationToken);
}