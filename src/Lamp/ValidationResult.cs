namespace Lamp;

public sealed class ValidationResult
{
    [MemberNotNullWhen(false, nameof(ErrorMessage))]
    public bool Successful { get; }
    public string? ErrorMessage { get; }

    private ValidationResult(string? errorMessage)
    {
        Successful = errorMessage != null;
        ErrorMessage = errorMessage;
    }

    public static ValidationResult Success()
    {
        return new ValidationResult(null);
    }

    public static ValidationResult Error(string message)
    {
        ArgumentNullException.ThrowIfNull(message);
        return new ValidationResult(message);
    }
}