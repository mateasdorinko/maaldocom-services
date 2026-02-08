namespace MaaldoCom.Services.Application.Queries.Knowledge;

public class GetRandomKnowledgeQuery(ClaimsPrincipal user) : BaseQuery(user), ICommand<Result<KnowledgeDto>> { }

public class GetRandomKnowledgeQueryHandler(ICacheManager cacheManager, ILogger<GetRandomKnowledgeQueryHandler> logger)
    : BaseQueryHandler<GetRandomKnowledgeQueryHandler>(cacheManager, logger), ICommandHandler<GetRandomKnowledgeQuery, Result<KnowledgeDto>>
{
    public async Task<Result<KnowledgeDto>> ExecuteAsync(GetRandomKnowledgeQuery query, CancellationToken ct)
    {
        var cachedKnowledge = (await CacheManager.ListKnowledgeAsync(ct)).ToList();

        var random = new Random();
        var randomKnowledge = cachedKnowledge[random.Next(cachedKnowledge.Count)];

        return Result.Ok(randomKnowledge);
    }
}
