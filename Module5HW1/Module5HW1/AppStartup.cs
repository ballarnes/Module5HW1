using Microsoft.Extensions.DependencyInjection;
using Module5HW1.Services.Abstractions;
using Module5HW1.Services;

namespace Module5HW1
{
    public class AppStartup
    {
        public void Set()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IUserService, UserService>()
                .AddSingleton<IResourceService, ResourceService>()
                .AddSingleton<IRegisterService, RegisterService>()
                .AddSingleton<ILoginService, LoginService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var appStart = serviceProvider.GetService<Starter>();
            appStart.Run();
        }
    }
}
