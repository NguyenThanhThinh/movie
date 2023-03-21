using AspNetCoreHero.ToastNotification;
using movie.core.Contracts;
using movie.core.Services;
using movie.data.Repositories;

namespace movie.web.Extensions
{
    public static class MoviesServiceCollectionExtencion
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICountryService, CountryService>();
            return services;
        }

        public static IServiceCollection AddNotyFService(this IServiceCollection services)
        {
            services.AddNotyf(configuration =>
            {
                configuration.DurationInSeconds = 5;
                configuration.IsDismissable = true;
                configuration.Position = NotyfPosition.TopRight;
            });

            return services;
        }
    }
}
