using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Model.Aggregates
{
    /// FavoriteSource Aggregate
    /// <summary>
    ///     This class represents the FavoriteSource aggregate. It is used to store the favorite sources of a user.
    /// </summary>
    public class FavoriteSource
    {
        public int Id { get; private set; }
        public string NewsApiKey { get; private set; }
        public string SourceId { get; private set; }

        public FavoriteSource()
        {
            this.NewsApiKey = string.Empty;
            this.SourceId = string.Empty;
        }

        public FavoriteSource(string newsApiKey, string sourceId)
        {
            this.NewsApiKey = newsApiKey;
            this.SourceId = sourceId;
        }

        ///<summary>
        ///    Constructor for the FavoriteSource aggregate.
        ///</summary>
        ///<remarks>
        ///    The constructor is the command handler for the CreateFavoriteSourceCommand.
        ///</remarks>
        public FavoriteSource(CreateFavoriteSouceCommand command)
        {
            this.NewsApiKey = command.NewsApiKey;
            this.SourceId = command.SourceId;
        }
    }
}
