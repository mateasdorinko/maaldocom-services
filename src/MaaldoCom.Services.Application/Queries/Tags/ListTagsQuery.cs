using MaaldoCom.Services.Application.Dtos;
using MaaldoCom.Services.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace MaaldoCom.Services.Application.Queries.Tags;

public class ListTagsQuery(ClaimsPrincipal user) : BaseQuery(user), ICommand<Result<IEnumerable<TagDto>>> { }

public class ListTagsQueryHandler(IMaaldoComDbContext maaldoComDbContext, HybridCache hybridCache)
    : BaseQueryHandler(maaldoComDbContext, hybridCache), ICommandHandler<ListTagsQuery, Result<IEnumerable<TagDto>>>
{
    public async Task<Result<IEnumerable<TagDto>>> ExecuteAsync(ListTagsQuery query, CancellationToken cancellationToken)
    {
        var tags = await HybridCache.GetOrCreateAsync<IEnumerable<TagDto>>(
            TagListCacheKey,
            async _ => await GetTagsFromDbAsync(cancellationToken), cancellationToken: cancellationToken);

        return Result.Ok(tags);
    }

    private async Task<IEnumerable<TagDto>> GetTagsFromDbAsync(CancellationToken cancellationToken)
    {
        var entities = await MaaldoComDbContext.Tags.ToListAsync(cancellationToken);
        return entities.ToDtos();
    }
}