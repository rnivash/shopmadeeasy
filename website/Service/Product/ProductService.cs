using System.Text.Json;

public interface IProductService
{
    Task<ICollection<Product>> GetProducts();
}

public class ProductService : IProductService
{
    private readonly ILogger _logger;

    private readonly HttpClient _httpClient;

    public ProductService(ILogger<ProductService> logger, HttpClient httpClient){
        _logger = logger;
        _httpClient = httpClient;
    }

    public async Task<ICollection<Product>> GetProducts(){

        _logger.LogInformation("Received request for products");

        var response =await _httpClient.GetAsync("product");

        if(response.IsSuccessStatusCode){
            _logger.LogInformation("Able to get result");
            var productStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<ICollection<Product>>(productStream,
            new JsonSerializerOptions{ PropertyNameCaseInsensitive = true });
        }

        return new List<Product>();

    }
    
}