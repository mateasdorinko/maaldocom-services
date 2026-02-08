namespace MaaldoCom.Services.Application.Commands;

public abstract class BaseCommand(ClaimsPrincipal user)
{
    public ClaimsPrincipal User { get; } = user;
}

#pragma warning disable S6672 // Generic logger type parameter is intentional for derived class typing
public abstract class BaseCommandHandler<THandler>
{
    protected BaseCommandHandler(IMaaldoComDbContext maaldoComDbContext, ICacheManager cacheManager, ILogger<THandler> logger)
    {
        MaaldoComDbContext = maaldoComDbContext;
        CacheManager = cacheManager;
        Logger = logger;

        MaaldoComDbContext.EnableChangeTracking();
    }

    protected IMaaldoComDbContext MaaldoComDbContext { get; }
    protected ICacheManager CacheManager { get; }
    protected ILogger<THandler> Logger { get; }
}
#pragma warning restore S6672
