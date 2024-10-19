namespace CatchUpPlatform.API.News.Interfaces.REST.Resources
{
    /// <summary>
    ///    Represents the data provided by the client to create a favorite source.
    /// </summary>
    /// <param name="NewsApiKey">The news api key</param>
    /// <param name="SourceId">The source id</param>
    public record CreateFavoriteSourceResource(string NewsApiKey, string SourceId);
}
