using movie.core.ViewModels.Genres;

namespace movie.core.Contracts
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreViewModel>> GetAllGenresAsync();
    }
}
