namespace CatchUpPlatform.API.News.Domain.Model.Queries
{
    /// <summary>
    ///     Query to get a favorite source by its ID.
    /// </summary>
    /// <param name="Id">The ID of the favorite source.</param>
    public record GetFavoriteSourceByIdQuery(int Id);
}