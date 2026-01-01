using MaaldoCom.Services.Application.Dtos;
using MaaldoCom.Services.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace MaaldoCom.Services.Application.Queries.Knowledge;

public class ListKnowledgeQuery(ClaimsPrincipal user) : BaseQuery(user), ICommand<Result<IEnumerable<KnowledgeDto>>> { }

public class ListKnowledgeQueryHandler(IMaaldoComDbContext maaldoComDbContext, HybridCache hybridCache)
    : BaseQueryHandler(maaldoComDbContext, hybridCache), ICommandHandler<ListKnowledgeQuery, Result<IEnumerable<KnowledgeDto>>>
{
    public async Task<Result<IEnumerable<KnowledgeDto>>> ExecuteAsync(ListKnowledgeQuery query, CancellationToken cancellationToken)
    {
        var knowledge = await HybridCache.GetOrCreateAsync<IEnumerable<KnowledgeDto>>(
            KnowledgeListCacheKey,
            async _ => await GetKnowledgeFromDbAsync(cancellationToken), cancellationToken: cancellationToken);

        return Result.Ok(knowledge);
    }

    private async Task<IEnumerable<KnowledgeDto>> GetKnowledgeFromDbAsync(CancellationToken cancellationToken)
    {
        var entities = await MaaldoComDbContext.Knowledge.ToListAsync(cancellationToken);
        return entities.ToDtos();
    }
}