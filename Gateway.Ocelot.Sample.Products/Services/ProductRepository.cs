using Gateway.Ocelot.Sample.Products.Model;

namespace Gateway.Ocelot.Sample.Products.Services
{
    public class ProductRepository : List<Product>, IProductRepository
    {
        private static readonly List<Product> _products = SeedProducts();

        private static List<Product> SeedProducts()
        {
            var result = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Mobile phone",
                    Description = "HTC, 5G, 2SIM"
                },
                new Product
                {
                    Id = 2,
                    Name = "T-Shirt",
                    Description = "Sizes: L, XL, XXL"
                },
                new Product {
                    Id = 3,
                    Name = "Keyboard",
                    Description = "Black, With Numpad"
                }
            };

            return result;
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(f => f.Id == id);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        Product IProductRepository.Add(Product product)
        {
            product.Id = _products.Max(f => f.Id) + 1;
            _products.Add(product);
            return product;
        }
    }
}
