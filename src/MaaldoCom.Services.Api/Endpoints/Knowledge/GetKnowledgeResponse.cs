namespace MaaldoCom.Services.Api.Endpoints.Knowledge;

public class GetKnowledgeResponse : BaseModel
{
    public string? Title { get; set; }
    public string? Quote { get; set; }
}