using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Domain.Repositories
{
    /// <summary>
    ///     The Favorite source repository contract.
    /// </summary>
    public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
    {
        /// <summary>
        ///     Find a favorite source by its news API key.
        /// </summary>
        /// <param name="newsApiKey">The news API key.</param>
        /// <returns>
        ///     An Enumerable of favorite sources.
        /// </returns>
        Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey);

        /// <summary>
        ///     Find a favorite source by news API key and source ID.
        /// </summary>
        /// <param name="newsApiKey">The news API key.</param>
        /// <param name="sourceId">The source ID.</param>
        /// <returns>
        ///     The favorite source object if found, null otherwise.
        /// </returns>
        Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);

    }
}
