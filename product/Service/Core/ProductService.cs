namespace Service.Core
{
    public interface IProductService
    {
        ICollection<Product> GetProduct();
        
    }

    public class ProductService : IProductService
    {
        public ICollection<Product> GetProduct(){
            return new[]{
                new Product{
                    Id = 1,
                    Name = "Coke",
                    Price = 45
                },
                new Product{
                    Id = 2,
                    Name = "Pepsi",
                    Price = 40
                }
            };
        }
    }
}
