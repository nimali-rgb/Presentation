using Infrastructure.Models;

namespace Infrastructure.Services;

public interface IFileService
{
    void Initalizer();
    IEnumerable<Product> ReadFromFile();
    void WriteToFile(IEnumerable<Product> products);
}