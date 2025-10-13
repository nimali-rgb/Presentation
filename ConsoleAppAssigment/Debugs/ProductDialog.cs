using Infrastructure.Models;
using Infrastructure.Services;

namespace ConsoleAppAssigment.Debugs;

public class ProductDialog (IProductService productService)
{
    private readonly IProductService _productService = productService;


    public void AddProductDialog()
    {
        var product = new Product();

        Console.Clear();
        Console.WriteLine("  -New Product-  ");

        Console.Write(" Product Name: ");
        product.Name = Console.ReadLine()!;

        Console.Write(" Product Price: ");
        decimal.TryParse(Console.ReadLine(), out decimal price);
        product.Price = price;

        _productService.AddProductToList(product);
    }

}