using Microsoft.Extensions.DependencyInjection;
using QedClientApp.Services;
using QedClientApp.Services.Abstract;
using QedClientApp.ViewModels;

namespace QedClientApp
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddTransient<IHttpService,HttpService>();
            collection.AddTransient<MainWindowViewModel>();
        }
    }
}
