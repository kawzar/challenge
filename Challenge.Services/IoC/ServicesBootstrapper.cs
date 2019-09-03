using AutoMapper;
using Challenge.Data.IoC;
using Challenge.Services.Mapping;
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
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IPostsService, PostsService>();
            services.AddScoped<IUsersService, UsersService>();

            return services;
        }
    }
}
