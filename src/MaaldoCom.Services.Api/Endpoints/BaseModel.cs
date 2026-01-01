namespace MaaldoCom.Services.Api.Endpoints;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public string? Href { get; set; }
}