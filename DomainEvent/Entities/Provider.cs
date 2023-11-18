namespace DomainEvent.Entities;

public sealed class Provider
{
    public ProviderId Id { get; private set; }
}
public record ProviderId(int Value);

