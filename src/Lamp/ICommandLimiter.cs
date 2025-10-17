using System.ComponentModel;

namespace Lamp;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface ICommandLimiter<out TSettings> : ICommand
    where TSettings : CommandSettings
{
}