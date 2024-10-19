namespace CatchUpPlatform.API.News.Interfaces.REST.Resources
{
    /// <summary>
    ///  Represents the data provided by the server about a favorite source.
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="NewsApiKey"></param>
    /// <param name="SourceId"></param>
    public record FavoriteSourceResource(int Id, string NewsApiKey, string SourceId);
}
