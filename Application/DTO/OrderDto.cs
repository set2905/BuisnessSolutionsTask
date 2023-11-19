
using Domain.Entities;

namespace Application.DTO;

public record OrderDto
{
    public OrderDto(string number, DateTime date, ProviderId providerId)
    {
        Number=number;
        Date=date;
        ProviderId=providerId;
    }

    public string Number { get; set; }
    public DateTime Date { get; set; }
    public ProviderId ProviderId { get; set; }
}
