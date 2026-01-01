using MaaldoCom.Services.Application.Queries.Knowledge;

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
        var dto = await new GetRandomKnowledgeQuery(User).ExecuteAsync(ct);
        var response = dto.ToModel();
        
        await Send.OkAsync(response, ct);
    }
}