namespace Application.DTO;

public record OrderItemDto(string Name,
                           decimal Quantity,
                           string Unit);
