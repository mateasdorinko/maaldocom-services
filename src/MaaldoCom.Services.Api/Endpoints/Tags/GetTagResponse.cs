namespace MaaldoCom.Services.Api.Endpoints.Tags;

public class GetTagResponse : BaseModel
{
    [JsonPropertyOrder(2)]
    public string? Name { get; set; }
    
    [JsonPropertyOrder(1)]
    public override string? Href => $"{Constants.TagsRoute}/{Id}";
}