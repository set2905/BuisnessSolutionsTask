﻿
using Domain.Entities;

namespace Application.DTO;

public record OrderDto(OrderId? Id,
                       string Number,
                       DateTime Date,
                       ProviderDto Provider,
                       OrderItemDto[] Items);
