namespace MaaldoCom.Services.Api.Endpoints;

internal static class UrlMaker
{
    public const string MediaAlbumsRoute = "/media-albums";
    public static string GetMediaAlbumUrl(Guid id) => GetMediaAlbumUrl(id.ToString());
    public static string GetMediaAlbumUrl(string idOrUrlFriendlyName) => $"{MediaAlbumsRoute}/{idOrUrlFriendlyName}";
    public static string GetMediaUrl(Guid mediaAlbumId, Guid mediaId) => GetMediaUrl(mediaAlbumId.ToString(), mediaId.ToString());
    public static string GetMediaUrl(string mediaAlbumId, string mediaId) => $"{MediaAlbumsRoute}/{mediaAlbumId}/media/{mediaId}";

    public const string KnowledgeRoute = "/knowledge";
    public static string GetKnowledgeUrl(Guid id) => $"{KnowledgeRoute}/{id}";
    public static string GetKnowledgeUrl(string idRouteParam) => $"{KnowledgeRoute}/{idRouteParam}";
    public static string GetRandomKnowledgeUrl() => $"{KnowledgeRoute}/random";

    public const string TagsRoute = "/tags";
    public static string GetTagUrl(Guid id) => GetTagUrl(id.ToString());
    public static string GetTagUrl(string idOrName) => $"{TagsRoute}/{idOrName}";

    public const string SupportRoute = "/support";
    public static string GetCacheRefreshUrl() => $"{SupportRoute}/cache-refresh";
}