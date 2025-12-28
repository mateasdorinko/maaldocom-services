using MaaldoCom.Services.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace MaaldoCom.Services.Application.Dtos;

public partial class Mapper
{
    public partial MediaAlbum ToMediaAlbum(MediaAlbumDto mediaAlbumDto);
    
    [MapperIgnoreTarget(nameof(Media.MediaAlbum))]
    public partial Media ToMedia(MediaDto mediaDto);
    
    [MapperIgnoreSource(nameof(TagDto.Created))]
    [MapperIgnoreSource(nameof(TagDto.CreatedBy))]
    [MapperIgnoreSource(nameof(TagDto.LastModified))]
    [MapperIgnoreSource(nameof(TagDto.LastModifiedBy))]
    [MapperIgnoreSource(nameof(TagDto.Active))]
    public partial Tag ToTag(TagDto tagDto);
    
    public partial Knowledge ToKnowledge(KnowledgeDto knowledgeDto);
}