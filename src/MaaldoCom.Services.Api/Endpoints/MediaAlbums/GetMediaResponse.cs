using MaaldoCom.Services.Api.Endpoints.Tags;

namespace MaaldoCom.Services.Api.Endpoints.MediaAlbums;

public class GetMediaResponse : BaseModel
{
    public string? FileName { get; set; }
    public string? Description { get; set; }
    public long SizeInBytes { get; set; }
    public IEnumerable<string> Tags { get; set; } = new List<string>();
    
    [JsonIgnore]
    public Guid MediaAlbumId { get; set; }
    
    public override string? Href => $"{Constants.MediaAlbumsRoute}/{MediaAlbumId}/media/{Id}";
}