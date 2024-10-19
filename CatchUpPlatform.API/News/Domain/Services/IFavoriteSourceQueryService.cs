using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;

namespace CatchUpPlatform.API.News.Domain.Services
{
    /// <summary>
    ///     Interface for the FavoriteSourceQueryService
    /// </summary>
    /// <remarks>
    ///     This insterface defines the basic operations for the FavoriteSourceQueryService
    /// </remarks>
    public interface IFavoriteSourceQueryService
    {
        /// <summary>
        ///     Handle the GetFavoriteSourceByIdQuery
        /// </summary>
        /// <remarks>
        ///     This method handles the GetFavoriteSourceByIdQuery. It returns the FavoriteSource with the given id.
        /// </remarks>
        /// <param name="query">The GetFavoriteSourceByIdQuery</param>
        /// <returns>The FavoriteSource object if found, or null otherwise</returns>
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);

        /// <summary>
        ///     Handle the GetFavoriteSourceByNewsApiKeyAndSourceIdQuery
        /// </summary>
        /// <remarks>
        ///     This method handles the GetFavoriteSourceByNewsApiKeyAndSourceIdQuery. It returns the FavoriteSource with the given id.
        /// </remarks>
        /// <param name="query">The GetFavoriteSourceByNewsApiKeyAndSourceIdQuery</param>
        /// <returns>The FavoriteSource object if found, or null otherwise</returns>
        Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    }
}
