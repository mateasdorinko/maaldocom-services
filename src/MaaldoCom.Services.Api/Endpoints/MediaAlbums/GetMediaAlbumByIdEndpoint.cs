using MaaldoCom.Services.Application.Queries.MediaAlbums;

namespace MaaldoCom.Services.Api.Endpoints.MediaAlbums;

public class GetMediaAlbumByIdEndpoint : Endpoint<GetMediaAlbumByIdRequest, GetMediaAlbumDetailResponse>
{
    public override void Configure()
    {
        Get($"{Constants.MediaAlbumsRoute}/{{id:guid}}");
        ResponseCache(60);
        AllowAnonymous();
        Description(b => b.Produces(StatusCodes.Status404NotFound));
    }

    public override async Task HandleAsync(GetMediaAlbumByIdRequest req, CancellationToken ct)
    {
        var result = (await new ListMediaAlbumsQuery(User).ExecuteAsync(ct)).Value;
        var response = result.ToDetailModels().FirstOrDefault(x => x.Id == req.Id);

        if (response is null)
        {
            await Send.NotFoundAsync(ct);
            return;
        }

        await Send.OkAsync(response, ct);
    }
}