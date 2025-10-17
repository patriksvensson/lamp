namespace Lamp;

public abstract class CommandSettings
{
    public virtual ValidationResult Validate()
    {
        return ValidationResult.Success();
    }
}