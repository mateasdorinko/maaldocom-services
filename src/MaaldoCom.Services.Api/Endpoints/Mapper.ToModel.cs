using MaaldoCom.Services.Api.Endpoints.Knowledge;
using MaaldoCom.Services.Api.Endpoints.MediaAlbums;
using MaaldoCom.Services.Application.Dtos;
using Riok.Mapperly.Abstractions;

namespace MaaldoCom.Services.Api.Endpoints;

public partial class Mapper
{
    [MapperIgnoreSource(nameof(MediaAlbumDto.Description))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.Media))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.LastModifiedBy))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.LastModified))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.CreatedBy))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.Active))]
    public partial GetMediaAlbumResponse ToGetMediaAlbumResponse(MediaAlbumDto dto);
    
    public partial IEnumerable<GetMediaAlbumResponse> ToGetMediaAlbumResponses(IEnumerable<MediaAlbumDto> dtos);
    
    [MapperIgnoreSource(nameof(MediaAlbumDto.LastModifiedBy))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.LastModified))]
    [MapperIgnoreSource(nameof(MediaAlbumDto.CreatedBy))]
    public partial GetMediaAlbumDetailResponse ToGetMediaAlbumDetailResponse(MediaAlbumDto dto);
    
    public partial IEnumerable<GetMediaAlbumDetailResponse> ToGetMediaAlbumDetailResponses(IEnumerable<MediaAlbumDto> dtos);
    
    [MapperIgnoreSource(nameof(MediaDto.Active))]
    [MapperIgnoreSource(nameof(MediaDto.MediaAlbumId))]
    [MapperIgnoreSource(nameof(MediaDto.SizeInBytes))]
    [MapperIgnoreSource(nameof(MediaDto.FileExtension))]
    [MapperIgnoreSource(nameof(MediaDto.Created))]
    [MapperIgnoreSource(nameof(MediaDto.CreatedBy))]
    [MapperIgnoreSource(nameof(MediaDto.LastModified))]
    [MapperIgnoreSource(nameof(MediaDto.LastModifiedBy))]
    public partial GetMediaResponse ToGetMediaResponse(MediaDto dto);
    
    public partial IEnumerable<GetMediaResponse> ToGetMediaResponses(IEnumerable<MediaDto> dtos);
    
    public partial GetKnowledgeResponse ToGetKnowledgeResponse(KnowledgeDto dto);
}