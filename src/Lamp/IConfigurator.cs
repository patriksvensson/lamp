namespace Lamp;

public interface IConfigurator
{
    IConfigurator AddExample(params string[] args);

    ICommandConfigurator AddCommand<TCommand>(string name)
        where TCommand : class, ICommand;

    ICommandConfigurator AddDelegate<TSettings>(
        string name,
        Func<CommandContext, TSettings, CancellationToken, int> func)
        where TSettings : CommandSettings;

    ICommandConfigurator AddAsyncDelegate<TSettings>(
        string name,
        Func<CommandContext, TSettings, CancellationToken, Task<int>> func)
        where TSettings : CommandSettings;

    IBranchConfigurator AddBranch<TSettings>(string name, Action<IConfigurator<TSettings>> action)
        where TSettings : CommandSettings;
}

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public interface IConfigurator<in TSettings>
    where TSettings : CommandSettings
{
    void SetDescription(string description);
    void AddExample(params string[] args);
    void HideBranch();

    void SetDefaultCommand<TDefaultCommand>()
        where TDefaultCommand : class, ICommandLimiter<TSettings>;

    ICommandConfigurator AddCommand<TCommand>(string name)
        where TCommand : class, ICommandLimiter<TSettings>;

    ICommandConfigurator AddDelegate<TDerivedSettings>(
        string name,
        Func<CommandContext, TDerivedSettings, CancellationToken, int> func)
        where TDerivedSettings : TSettings;

    ICommandConfigurator AddAsyncDelegate<TDerivedSettings>(
        string name,
        Func<CommandContext, TDerivedSettings, CancellationToken, Task<int>> func)
        where TDerivedSettings : TSettings;

    IBranchConfigurator AddBranch<TDerivedSettings>(
        string name, Action<IConfigurator<TDerivedSettings>> action)
        where TDerivedSettings : TSettings;
}