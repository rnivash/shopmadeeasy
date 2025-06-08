namespace Service.Infra
{
    public static class InversionOfControl
    {
        public static void Register(this IServiceCollection service){

            service.AddHttpClient<IProductService, ProductService>(httpClient =>{
                httpClient.BaseAddress = new Uri("https://localhost:7079/");
            });

        }
    } 
}
