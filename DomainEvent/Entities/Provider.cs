﻿namespace Domain.Entities;

public sealed class Provider
{
    public Provider()
    {
    }

    public ProviderId Id { get; private set; }
    public string Name { get; private set; }
}
public record ProviderId(int Value);

