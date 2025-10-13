using Infrastructure.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Infrastructure.Services;

public class FileService : IFileService
{
    private static string _directoryPath = @"c:\cms25\prg1\data";
    private string _filePath = Path.Combine(_directoryPath, "product.json");

    public FileService()
    {
        Initalizer();
    }

    public void Initalizer()
    {
        if (!Directory.Exists(_directoryPath))
        {
            Directory.CreateDirectory(_directoryPath);

            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, []);
        }
    }

   public void WriteToFile(IEnumerable<Product> products)
    {
        var json = JsonConvert.SerializeObject(products);
        File.WriteAllText(_filePath, json);
    }

    public IEnumerable<Product> ReadFromFile()
    {
        var content = File.ReadAllText(_filePath);
        var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
        return products!;
    }

   
}
