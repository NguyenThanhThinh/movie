using movie.core.Contracts;
using movie.core.ViewModels.Genres;
using movie.data.Entities;
using movie.data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace movie.core.Services;

public class GenreService : IGenreService
{
    private readonly IRepository<Genre> genresRepository;

    public GenreService(IRepository<Genre> genresRepository)
    {
        this.genresRepository = genresRepository;
    }

    public async Task<IEnumerable<GenreViewModel>> GetAllGenresAsync()
    {
        var genres = await genresRepository
            .AllAsNoTracking()
            .Select(x => new GenreViewModel()
            {
                Id = x.Id,
                Name = x.Type
            })
            .ToListAsync();

        return genres;
    }
}