namespace Lamp;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class CommandOptionAttribute : Attribute
{
    public CommandOptionAttribute(string template)
    {
        throw new NotSupportedException();
    }
}