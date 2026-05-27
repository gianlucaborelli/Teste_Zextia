using Microsoft.Extensions.DependencyInjection;
using Zextia.Data;
using Zextia.Forms;
using Zextia.Repositories;
using Zextia.Services;

namespace Zextia.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ApplicationDbContext>();

            services.AddTransient<IProductRepository, ProductRepository>();            

            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<MainForm>();
            services.AddTransient<ProductEditorForm>();
            services.AddTransient<ManagerProductSupplementForm>();
            services.AddTransient<SupplementEditorForm>();

            return services;
        }
    }
}
