namespace CatchUpPlatform.API.News.Domain.Model.Commands
{
    public record CreateFavoriteSouceCommand(string NewsApiKey, string SourceId);
}
