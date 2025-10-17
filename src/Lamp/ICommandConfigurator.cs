namespace Lamp;

public interface ICommandConfigurator
{
    ICommandConfigurator WithExample(params string[] args);
    ICommandConfigurator WithAlias(string name);
    ICommandConfigurator WithDescription(string description);
    ICommandConfigurator WithData(object data);
    ICommandConfigurator IsHidden();
}