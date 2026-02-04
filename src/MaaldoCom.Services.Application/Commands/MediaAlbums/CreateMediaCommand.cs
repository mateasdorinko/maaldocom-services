namespace MaaldoCom.Services.Application.Commands.MediaAlbums;

public class CreateMediaCommand(ClaimsPrincipal user) : BaseCommand(user), ICommand<Result<MediaDto>>
{
    public required MediaDto Media { get; set; }
}

public class CreateMediaCommandHandler(IMaaldoComDbContext maaldoComDbContext)
    : BaseCommandHandler(maaldoComDbContext), ICommandHandler<CreateMediaCommand, Result<MediaDto>>
{
    public async Task<Result<MediaDto>> ExecuteAsync(CreateMediaCommand command, CancellationToken ct)
    {
        await Task.Delay(0);
        return new Result<MediaDto>();
    }
}

public class CreateMediaCommandValidator : AbstractValidator<CreateMediaCommand>
{
    public CreateMediaCommandValidator()
    {
        RuleFor(x => x.Media).SetValidator(new CreateMediaValidator());
    }
}
