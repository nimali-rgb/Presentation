
using Infrastructure.Models;

namespace Infrastructure.Services;

public class ProductService
{
    private List<Product> _products = [];
    private readonly IFileService _fileService = fileService

        public void AddProductToList(Product, product)
    {
        Product.Id = Guid.NewGuid.ToString();

        _products.Add(product);

        _fileService.WriteToFile(_products);
    }

    public IEnumerable<Product> GetProductFromList()
    {
        _products = [.. _fileService.ReadFromFile()];
        return _products.OrderBy(product => product.Name);
    }

}
