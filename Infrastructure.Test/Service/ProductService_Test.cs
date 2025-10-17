
using Infrastructure.Models;
using Infrastructure.Services;
using Moq;


namespace Infrastructure.Test.Service;

public class ProductService_Test
{
    [Fact]
    public void AddProductToList_ShouldAddOneProductToList()
    {
        //Arrange

        var products = new Product { Name = "Test Product", Price = 100 };

        var fileServiceMock = new Mock<IFileService>();
        fileServiceMock.Setup(x => x.WriteToFile(It.IsAny<IEnumerable<Product>>()));
        fileServiceMock.Setup(x => x.ReadFromFile()).Returns([products]);

        var prodcutService = new ProductService(fileServiceMock.Object);


        //Act
        prodcutService.AddProductToList(products);

        //Assert

        var product = prodcutService.GetProductFromList();
        Assert.Single(product);
    }
}

