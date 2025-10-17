

namespace ConsoleAppAssigment.Debugs;

public class MenuDialog(ProductDialog productDialogs)
{
    private readonly ProductDialog _productDialogs = productDialogs;

    public void MenuOptionDialog()
    {
        Console.Clear();
        Console.WriteLine("-----New Menu Option-----");
        Console.WriteLine(" 1. View Product List ");
        Console.WriteLine(" 2. New Product ");

        Console.Write(" Chosse A Menu Option ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                _productDialogs.ListProductDialog();

                break;

            case "2":
                _productDialogs.AddProductDialog();
                break;
        }
    }


    public void Run()
    {
        while (true)
        {
            MenuOptionDialog();
        }
    }
}
