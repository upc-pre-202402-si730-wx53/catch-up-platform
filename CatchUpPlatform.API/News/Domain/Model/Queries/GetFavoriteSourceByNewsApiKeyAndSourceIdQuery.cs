namespace CatchUpPlatform.API.News.Domain.Model.Queries
{
    /// <summary>
    ///     Query to get a favorite source by News API key and source ID.
    /// </summary>
    /// <param name="NewsApiKey">The news API key.</param>
    /// <param name="SourceId">The source ID.</param>
    public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string NewsApiKey, string SourceId);
}