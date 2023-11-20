using Domain.Entities;

namespace Application.DTO;

public record OrderItemDto(OrderItemId? Id,
                           string Name,
                           decimal Quantity,
                           string Unit);
