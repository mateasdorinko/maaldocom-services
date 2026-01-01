namespace MaaldoCom.Services.Api.Endpoints.Knowledge;

public class GetKnowledgeResponse : BaseModel
{
    public string? Title { get; set; }
    public string? Quote { get; set; }
    
    public override string? Href => $"{Constants.KnowledgeRoute}/{Id}";
}