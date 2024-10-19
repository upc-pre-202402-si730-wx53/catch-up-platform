namespace CatchUpPlatform.API.News.Domain.Model.Commands
{
    /// <summary>
    ///     Command to create a favorite source.
    /// </summary>
    /// <param name="NewsApiKey">The news API key.</param>
    /// <param name="SourceId">The source ID.</param>
    public record CreateFavoriteSouceCommand(string NewsApiKey, string SourceId);
}
