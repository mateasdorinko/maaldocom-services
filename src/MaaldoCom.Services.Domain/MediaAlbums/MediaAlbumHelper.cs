namespace MaaldoCom.Services.Domain.MediaAlbums;

public static class MediaAlbumHelper
{
    public static bool IsPic(FileInfo file)
    {
        var picExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp" };
        return picExtensions.Contains(file.Extension, StringComparer.OrdinalIgnoreCase);
    }

    public static bool IsVid(FileInfo file)
    {
        var vidExtensions = new[] { ".mp4", ".mov", ".avi", ".mkv", ".wmv", ".flv",".webm" };
        return vidExtensions.Contains(file.Extension, StringComparer.OrdinalIgnoreCase);
    }

    public static void SanitizeFileName(FileInfo file)
    {
        // update name
        var newName = file.Name
            .Replace("_", "-")
            .ToLower();

        // replace file
        file.MoveTo($"{file.DirectoryName}\\{newName}", true);
    }

    public static string GetNameFromFolder(string folderName)
    {
        var parts = folderName.Split(['-'], StringSplitOptions.RemoveEmptyEntries);

        var words = parts.Select(p =>
        {
            var lower = p.ToLowerInvariant();
            return char.ToUpperInvariant(lower[0]) + (lower.Length > 1 ? lower.Substring(1) : string.Empty);
        });

        return string.Join(" ", words);
    }
}
