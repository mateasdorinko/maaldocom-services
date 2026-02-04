using MaaldoCom.Services.Api.Endpoints.MediaAlbums.Models;
using MaaldoCom.Services.Application.Commands.MediaAlbums;

namespace MaaldoCom.Services.Api.Endpoints.MediaAlbums;

public class PostMediaAlbumEndpoint : Endpoint<PostMediaAlbumRequest, PostMediaAlbumResponse>
{
    public override void Configure()
    {
        Post(UrlMaker.MediaAlbumsRoute);
        Permissions("write:media-albums");
        Description(x => x
            .WithName("PostMediaAlbum")
            .WithSummary("Creates a new media album."));
    }

    public override async Task HandleAsync(PostMediaAlbumRequest req, CancellationToken ct)
    {
        var dto = req.ToDto();
        var result = await new CreateMediaAlbumCommand(User, dto).ExecuteAsync(ct);
        var response = result.Value.ToModel();

        await Send.CreatedAtAsync(string.Empty, response, cancellation: ct);
    }
}
