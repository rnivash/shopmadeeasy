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
                    Price = 45,
                    ImageUrl = "https://m.media-amazon.com/images/I/51aEtMztfHL._SY450_.jpg"
                },
                new Product{
                    Id = 2,
                    Name = "Pepsi",
                    Price = 40,
                    ImageUrl = "https://m.media-amazon.com/images/I/81T3olLXpUL._SL1500_.jpg"
                }
            };
        }
    }
}
