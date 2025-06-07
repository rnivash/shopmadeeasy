using Service.Core;

namespace Service.Infra
{
    public static class InversionOfControl
    {
        public static void Register(this IServiceCollection service){

            service.AddScoped<IProductService, ProductService>();

        }
    } 
}
