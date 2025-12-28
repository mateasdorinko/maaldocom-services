using MaaldoCom.Services.Domain.Entities;

namespace MaaldoCom.Services.Application.Dtos;

public class KnowledgeDto : BaseEntity
{
    public string? Title { get; set; }
    public string? Quote { get; set; }
}