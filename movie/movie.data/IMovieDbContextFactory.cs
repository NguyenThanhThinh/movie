using Microsoft.EntityFrameworkCore;
using movie.data.Data;

namespace movie.data
{
    public interface IMovieDbContextFactory : IDbContextFactory<MovieDbContext>
    {
    }

    public class TenantDbContextFactory : IMovieDbContextFactory
    {
        private readonly DbContextOptions<MovieDbContext> _options;
        public TenantDbContextFactory(DbContextOptions<MovieDbContext> options)
        {
            _options = options;
        }

        public MovieDbContext CreateDbContext()
        {
            var db = new MovieDbContext(_options);

            // todo: config db

            return db;
        }
    }
}
