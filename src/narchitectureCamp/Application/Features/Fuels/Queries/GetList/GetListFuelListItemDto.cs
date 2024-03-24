using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Fuels.Queries.GetList;

public class GetListFuelListItemDto : IDto
{
    public string Name { get; set; }
    public Guid Id { get; set; }
}