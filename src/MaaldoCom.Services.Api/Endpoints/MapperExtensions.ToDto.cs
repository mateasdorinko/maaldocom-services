using MaaldoCom.Services.Application.Dtos;
using MaaldoCom.Services.Api.Endpoints.MediaAlbums;
using MaaldoCom.Services.Api.Endpoints.Knowledge;

namespace MaaldoCom.Services.Api.Endpoints;

public static partial class MapperExtensions
{
    public static MediaAlbumDto ToDto(this GetMediaAlbumResponse model)
    {
        return new MediaAlbumDto
        {
            Id = model.Id,
            Name = model.Name,
            UrlFriendlyName = model.UrlFriendlyName,
            Created = model.Created,
            Tags = model.Tags.Select(m => m.ToDto()).ToList()
        };
    }

    public static MediaAlbumDto ToDto(this GetMediaAlbumDetailResponse model)
    {
        return new MediaAlbumDto
        {
            Id = model.Id,
            Name = model.Name,
            UrlFriendlyName = model.UrlFriendlyName,
            Created = model.Created,
            Description = model.Description,
            Active = model.Active,
            Media = model.Media.Select(m => m.ToDto()).ToList(),
            Tags = model.Tags.Select(m => m.ToDto()).ToList()
        };
    }

    public static MediaDto ToDto(this GetMediaResponse model)
    {
        return new MediaDto
        {
            Id = model.Id,
            FileName = model.FileName,
            Description = model.Description
        };
    }

    private static TagDto ToDto(this string model)
    {
        return new TagDto
        {
            Name = model
        };
    }

    private static KnowledgeDto ToDto(this GetKnowledgeResponse model)
    {
        return new KnowledgeDto
        {
            Id = model.Id,
            Title = model.Title,
            Quote = model.Quote,
        };
    }
}