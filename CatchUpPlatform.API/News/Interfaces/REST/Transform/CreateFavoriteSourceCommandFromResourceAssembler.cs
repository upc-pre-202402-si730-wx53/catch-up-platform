using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Interfaces.REST.Resources;

namespace CatchUpPlatform.API.News.Interfaces.REST.Transform
{
    public static class CreateFavoriteSourceCommandFromResourceAssembler
    {
        public static CreateFavoriteSouceCommand ToCommandFromResource(CreateFavoriteSourceResource resource) => 
            new CreateFavoriteSouceCommand(resource.NewsApiKey, resource.SourceId);

    }
}
