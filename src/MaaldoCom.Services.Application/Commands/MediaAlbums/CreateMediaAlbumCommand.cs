namespace MaaldoCom.Services.Application.Commands.MediaAlbums;

public class CreateMediaAlbumCommand(ClaimsPrincipal user, MediaAlbumDto dto) : BaseCommand(user), ICommand<Result<MediaAlbumDto>>
{
    public MediaAlbumDto MediaAlbum { get; set; } = dto;
}

public class CreateMediaAlbumCommandHandler(IMaaldoComDbContext maaldoComDbContext)
    : BaseCommandHandler(maaldoComDbContext), ICommandHandler<CreateMediaAlbumCommand, Result<MediaAlbumDto>>
{
    public async Task<Result<MediaAlbumDto>> ExecuteAsync(CreateMediaAlbumCommand command, CancellationToken ct)
    {
        return await Task.FromResult(Result.Ok());
    }
}

public class CreateMediaAlbumCommandValidator : AbstractValidator<CreateMediaAlbumCommand>
{
    public CreateMediaAlbumCommandValidator(IMaaldoComDbContext maaldoComDbContext)
    {
        RuleFor(x => x.MediaAlbum)
            .NotNull()
            .WithMessage("Media album cannot be null");
        RuleFor(x => x.MediaAlbum).SetValidator(new CreateMediaAlbumValidator(maaldoComDbContext));
    }
}
