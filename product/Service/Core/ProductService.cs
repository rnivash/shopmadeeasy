namespace Service.Core
{
    public interface IProductService
    {
        string GetProduct();
        
    }

    public class ProductService : IProductService
    {
        public string GetProduct(){
            return "Coke! Pepsi";
        }
    }
}
