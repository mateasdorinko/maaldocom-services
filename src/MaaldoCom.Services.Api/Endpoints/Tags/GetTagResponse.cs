namespace MaaldoCom.Services.Api.Endpoints.Tags;

public class GetTagResponse : BaseModel
{
    public string? Name { get; set; }
    
    public override string? Href => $"{Constants.TagsRoute}/{Id}";
}