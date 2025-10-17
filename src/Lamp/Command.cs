namespace Lamp;

public abstract class Command<TSettings> : ICommand<TSettings>
    where TSettings : CommandSettings
{
    ValidationResult ICommand.Validate(CommandContext context, CommandSettings settings)
    {
        return Validate(context, (TSettings)settings);
    }

    Task<int> ICommand.ExecuteAsync(CommandContext context, CommandSettings settings, CancellationToken cancellationToken)
    {
        Trace.Assert(settings is TSettings, "Command settings is of unexpected type.");
        return ExecuteAsync(context, (TSettings)settings, cancellationToken);
    }

    public abstract Task<int> ExecuteAsync(CommandContext context, TSettings settings, CancellationToken cancellationToken);

    protected virtual ValidationResult Validate(CommandContext context, TSettings settings)
    {
        return ValidationResult.Success();
    }
}

public abstract class SyncCommand<TSettings> : ICommand<TSettings>
    where TSettings : CommandSettings
{
    ValidationResult ICommand.Validate(CommandContext context, CommandSettings settings)
    {
        return Validate(context, (TSettings)settings);
    }

    Task<int> ICommand.ExecuteAsync(CommandContext context, CommandSettings settings, CancellationToken cancellationToken)
    {
        Trace.Assert(settings is TSettings, "Command settings is of unexpected type.");
        return Task.FromResult(Execute(context, (TSettings)settings, cancellationToken));
    }

    Task<int> ICommand<TSettings>.ExecuteAsync(CommandContext context, TSettings settings, CancellationToken cancellationToken)
    {
        return Task.FromResult(Execute(context, settings, cancellationToken));
    }

    protected abstract int Execute(CommandContext context, TSettings settings, CancellationToken cancellationToken);

    protected virtual ValidationResult Validate(CommandContext context, TSettings settings)
    {
        return ValidationResult.Success();
    }
}