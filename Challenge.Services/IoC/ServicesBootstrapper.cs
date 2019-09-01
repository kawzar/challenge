using Challenge.Data.Context;
using Challenge.Services.Posts;
using Challenge.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Services.IoC
{
    public static class ServicesBootstrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ChallengeContext, ChallengeContext>();
            services.AddScoped<IPostsService, PostsService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
