using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using movie.data.Data;

namespace movie.web
{
    public class MovieDbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
    {
        public MovieDbContext CreateDbContext(string[] args)
        {
            var configrationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = configrationBuilder.Build();
            var connectionString = configuration.GetConnectionString("MovieDbContext");

            var dbContextOptionBuilder = new DbContextOptionsBuilder<MovieDbContext>();
            dbContextOptionBuilder.UseSqlServer(connectionString);

            return new MovieDbContext(dbContextOptionBuilder.Options);
        }
    }
}
