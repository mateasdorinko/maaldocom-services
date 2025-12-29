namespace MaaldoCom.Services.Api.Endpoints.MediaAlbums;

public class GetMediaAlbumDetailResponse : GetMediaAlbumResponse
{
    public string? Description { get; set; }
    public bool Active { get; set; }
    public IEnumerable<GetMediaResponse> Media { get; set; } = new List<GetMediaResponse>();
}