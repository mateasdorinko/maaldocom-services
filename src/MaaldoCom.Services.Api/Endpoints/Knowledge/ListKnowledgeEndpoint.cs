namespace MaaldoCom.Services.Api.Endpoints.Knowledge;

public class ListKnowledgeEndpoint : EndpointWithoutRequest<IEnumerable<GetKnowledgeResponse>>
{
    public override void Configure()
    {
        Get("/knowledge");
        ResponseCache(60);
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var response = new List<GetKnowledgeResponse>();
        await Send.OkAsync(response, ct);
    }
}