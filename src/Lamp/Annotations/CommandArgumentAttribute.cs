namespace Lamp;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class CommandArgumentAttribute : Attribute
{
    public CommandArgumentAttribute(int position, string template)
    {
        throw new NotSupportedException();
    }
}