using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using movie.data.Entities;

namespace movie.data.Data
{
    public class MovieDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieActor> MoviesActors { get; set; }

        public DbSet<MovieGenre> MoviesGenres { get; set; }

        public DbSet<MovieLanguage> MoviesLanguages { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<MovieCountry> MoviesCountries { get; set; }

        public DbSet<UserMovie> UserMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MovieActor>()
                .HasKey(x => new { x.MovieId, x.ActorId });

            builder.Entity<MovieGenre>()
                .HasKey(x => new { x.MovieId, x.GenreId });

            builder.Entity<MovieLanguage>()
                .HasKey(x => new { x.MovieId, x.LanguageId });

            builder.Entity<MovieCountry>()
                .HasKey(x => new { x.MovieId, x.CountryId });

            builder.Entity<UserMovie>()
                .HasKey(x => new { x.UserId, x.MovieId });

            base.OnModelCreating(builder);
        }
    }
}
