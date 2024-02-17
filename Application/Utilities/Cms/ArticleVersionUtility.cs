namespace Application.Utilities.Cms;

public class ArticleVersionUtility
{
    private int _articleVersion;
    private int _titleVersion;
    private int _contentVersion;
    private int _authorVersion;

    public ArticleVersionUtility()
    {
        _articleVersion = 1;
        _titleVersion = 0;
        _contentVersion = 0;
        _authorVersion = 0;
    }

    public string GetVersion()
    {
        return $"{_articleVersion}.{_titleVersion}.{_contentVersion}.{_authorVersion}";
    }

    public string UpdateTitle(string currentVersion)
    {
        var parts = currentVersion.Split('.');
        if (parts.Length != 4)
        {
            Console.WriteLine("Invalid version format.");
            return currentVersion;
        }

        if (int.TryParse(parts[0], out var majorVer) && int.TryParse(parts[1], out var titleVer) && int.TryParse(parts[2], out var contentVer) && int.TryParse(parts[3], out var authorVer))
        {
            _articleVersion = majorVer;
            _titleVersion = titleVer;
            _contentVersion = contentVer;
            _authorVersion = authorVer;

            _titleVersion++;

            //if (titleVer == _titleVersion && contentVer == _contentVersion && authorVer == _authorVersion)
            //{
            //    _titleVersion++;
            //    _majorVersion++;
            //}
            //else
            //{
            //    Console.WriteLine("Cannot update title. Current version does not match.");
            //}
        }
        else
        {
            Console.WriteLine("Invalid version format.");
        }

        return GetVersion();
    }

    //public string UpdateContent(string currentVersion)
    //{
    //    // Tương tự như UpdateTitle
    //}

    //public string UpdateAuthor(string currentVersion)
    //{
    //    // Tương tự như UpdateTitle
    //}
}