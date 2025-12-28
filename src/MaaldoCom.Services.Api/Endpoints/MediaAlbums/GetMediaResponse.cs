namespace MaaldoCom.Services.Api.Endpoints.MediaAlbums;

public class GetMediaResponse : BaseModel
{
    public string? FileName { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Tags { get; set; } = new List<string>();
}