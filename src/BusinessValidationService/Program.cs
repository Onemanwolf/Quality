
using BusinessValidationService.Services;
namespace BusinessValidationService;

class Program
{
    static void Main(string[] args)
    {
        //C:\Users\timot\source\repos\dp-203\Allfiles\labs\Quality\src\BusinessValidationService\bin\Debug\net7.0\./src/BusinessBusinessLogic/business.json
        var service = new BusinessSpecification();

        string relativePath = @"C:\Users\timot\source\repos\Quality\src\BusinessValidationService\BusinessLogic\business.json";

        service.LoadBusinessValidationConfig(relativePath);
        Console.WriteLine("Hello, World!");
    }
}
