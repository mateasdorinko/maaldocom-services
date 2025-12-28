using MaaldoCom.Services.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace MaaldoCom.Services.Application.Dtos;

[Mapper]
public partial class Mapper
{
    public partial MediaAlbumDto ToMediaAlbumDto(MediaAlbum mediaAlbum);
    
    [MapperIgnoreSource(nameof(Media.MediaAlbum))]
    public partial MediaDto ToMediaDto(Media media);
    
    [MapperIgnoreTarget(nameof(TagDto.Created))]
    [MapperIgnoreTarget(nameof(TagDto.CreatedBy))]
    [MapperIgnoreTarget(nameof(TagDto.LastModified))]
    [MapperIgnoreTarget(nameof(TagDto.LastModifiedBy))]
    [MapperIgnoreTarget(nameof(TagDto.Active))]
    public partial TagDto ToTagDto(Tag tag);
    
    public partial KnowledgeDto ToKnowledgeDto(Knowledge knowledge);
}