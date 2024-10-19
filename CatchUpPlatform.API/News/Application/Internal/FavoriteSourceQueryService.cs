using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.Internal
{
    /// <summary>
    ///     Favorite source query service.
    /// </summary>
    /// <remarks>
    ///     This class implements the basic operations for a favorite source query service.
    /// </remarks>
    /// <param name="favoriteSourceRepository">The FavoriteSourceRepository instance.</param>
    public class FavoriteSourceQueryService(IFavoriteSourceRepository favoriteSourceRepository, IUnitOfWork unitOfWork: IFavoriteSourceQueryService
    {
        /// <inheritdoc />
        public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            return await favoriteSourceRepository.FindByIdAsync(query.Id);
        }

        /// <inheritdoc />
        public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
           return await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId);
        }
    }
}
