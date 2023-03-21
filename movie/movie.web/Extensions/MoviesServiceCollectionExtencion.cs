using AspNetCoreHero.ToastNotification;

namespace movie.web.Extensions
{
    public static class MoviesServiceCollectionExtencion
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            
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
