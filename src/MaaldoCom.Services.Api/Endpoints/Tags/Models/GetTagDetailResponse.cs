using MaaldoCom.Services.Api.Endpoints.MediaAlbums.Models;

namespace MaaldoCom.Services.Api.Endpoints.Tags.Models;

public class GetTagDetailResponse : GetTagResponse
{
    [JsonPropertyOrder(3)]
    public IEnumerable<GetMediaAlbumResponse> TaggedMediaAlbums { get; set; } = new List<GetMediaAlbumResponse>();

    [JsonPropertyOrder(4)]
    public IEnumerable<GetMediaResponse> TaggedMedia { get; set; } = new List<GetMediaResponse>();
}