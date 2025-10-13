using Infrastructure.Models;

namespace Infrastructure.Services;

public interface IProductService
{
    void AddProductToList(Product product);

    IEnumerable<Product> GetProductFromList();
}