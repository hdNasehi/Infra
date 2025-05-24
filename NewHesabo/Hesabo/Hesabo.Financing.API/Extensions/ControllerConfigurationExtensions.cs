

namespace Hesabo.Financing.API.Extensions
{
    public static class ControllerConfigurationExtensions
    {
        public static IServiceCollection AddConfiguredControllers(this IServiceCollection services)
        {
            services.AddControllers(options =>
                {
                    options.SuppressAsyncSuffixInActionNames = true;
                    options.RespectBrowserAcceptHeader = true;
                })
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
                    opt.JsonSerializerOptions.WriteIndented = true;
                });

            return services;
        }
    }
    
}
