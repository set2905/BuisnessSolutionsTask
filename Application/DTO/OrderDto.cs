
using Domain.Entities;

namespace Application.DTO;

public record OrderDto(string Number,
                       DateTime Date,
                       ProviderId ProviderId,
                       OrderItemDto[] Items);
