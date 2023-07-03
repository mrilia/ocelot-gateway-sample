using Gateway.Ocelot.Sample.Products.Model;

namespace Gateway.Ocelot.Sample.Products.Services
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int id);
        Product Add(Product product);
    }
}
