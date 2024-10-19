using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Services
{
    /// <summary>
    ///     Interface for the FavoriteSourceCommandService
    /// </summary>
    /// <remarks>
    ///     This insterface defines the basic operations for the FavoriteSourceCommandService
    /// </remarks>
    public interface IFavoriteSourceCommandService
    {
        /// <summary>
        ///     Handle the CreateFavoriteSouceCommand
        /// </summary>
        /// <remarks>
        ///     This method handles the CreateFavoriteSouceCommand. It checks if the favorite source already exists, and if not, creates it.
        /// </remarks>
        /// <param name="command">CreateFavoriteSouceCommand</param>
        /// <returns>The FavoriteSource object if created, or null otherwise</returns>
        /// <exception cref="Exception"></exception>
        Task<FavoriteSource?> Handle(CreateFavoriteSouceCommand command);
    }
}
