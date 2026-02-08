namespace MaaldoCom.Services.Application.Queries;

public abstract class BaseQuery(ClaimsPrincipal user)
{
    public ClaimsPrincipal User { get; } = user;
}

#pragma warning disable S6672 // Generic logger type parameter is intentional for derived class typing
public abstract class BaseQueryHandler<THandler>(ICacheManager cacheManager, ILogger<THandler> logger)
#pragma warning restore S6672
{
    protected ICacheManager CacheManager { get; } = cacheManager;
    protected ILogger<THandler> Logger { get; } = logger;
}