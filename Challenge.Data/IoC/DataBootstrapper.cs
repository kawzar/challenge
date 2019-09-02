using Challenge.Data.Context;
using Challenge.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Data.IoC
{
    public static class DataBootstrapper
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ChallengeContext, ChallengeContext>();
            services.AddScoped<IPostsRepository, PostsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            return services;
        }
    }
}
