using System.Security.Claims;
using MaaldoCom.Services.Application.Dtos;
using MaaldoCom.Services.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace MaaldoCom.Services.Application.Queries.Knowledge;

public class GetRandomKnowledgeQuery(ClaimsPrincipal user) : BaseQuery(user), ICommand<KnowledgeDto> { }

public class GetRandomKnowledgeQueryHandler(IMaaldoComDbContext maaldoComDbContext, HybridCache hybridCache)
    : BaseQueryHandler(maaldoComDbContext, hybridCache), ICommandHandler<GetRandomKnowledgeQuery, KnowledgeDto>
{
    public async Task<KnowledgeDto> ExecuteAsync(GetRandomKnowledgeQuery query, CancellationToken cancellationToken)
    {
        var knowledge = await HybridCache.GetOrCreateAsync<IEnumerable<KnowledgeDto>>(
            KnowledgeListCacheKey,
            async _ => await GetKnowledgeFromDbAsync(cancellationToken), cancellationToken: cancellationToken);

        var random = new Random();
        var knowledgeList = knowledge.ToList();
        var randomKnowledge = knowledgeList.ElementAt(random.Next(knowledgeList.Count));

        return randomKnowledge;
    }

    private async Task<IEnumerable<KnowledgeDto>> GetKnowledgeFromDbAsync(CancellationToken cancellationToken)
    {
        var entities = await MaaldoComDbContext.Knowledge.ToListAsync(cancellationToken);
        return entities.ToDtos();
    }
}