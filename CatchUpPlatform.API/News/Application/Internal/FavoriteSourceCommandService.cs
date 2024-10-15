using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.Internal
{
    public class FavoriteSourceCommandService(IFavoriteSourceRepository favoriteSourceRepository, IUnitOfWork unitOfWork): IFavoriteSourceCommandService
    {
        public async Task<FavoriteSource?> Handle(CreateFavoriteSouceCommand command)
        {
            var favoriteSource = await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(command.NewsApiKey, command.SourceId);

            if(favoriteSource != null) throw new Exception("Favorite source already exists");

            favoriteSource = new FavoriteSource(command);

            try
            {
                await favoriteSourceRepository.AddAsync(favoriteSource);
                await unitOfWork.CompleteAsync();
            } catch(Exception e)
            {
                return null;
            }

            return favoriteSource;
        }
    }
}
