using Challenge.Data.IoC;
using Challenge.Services.Posts;
using Challenge.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Services.IoC
{
    public static class ServicesBootstrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            DataBootstrapper.RegisterRepositories(services);
            services.AddScoped<IPostsService, PostsService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
