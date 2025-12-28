namespace MaaldoCom.Services.Api.Endpoints.Knowledge;

public class GetRandomKnowledgeEndpoint : EndpointWithoutRequest<GetKnowledgeResponse>
{
    public override void Configure()
    {
        Get("/knowledge/random");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(CancellationToken ct)
    {
        var response = new GetKnowledgeResponse();
        await Send.OkAsync(response, ct);
    }
}