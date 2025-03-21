using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Components.DataProvider;
using MotoApp.Data.Entities;
using MotoApp.Data.Repositories;
using MotoApp.Components.CsvReader;


var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();
services.AddSingleton<IRepository<Car>, ListRepository<Car>>();
services.AddSingleton<ICarProvider, CarProvider>();
services.AddSingleton<ICsvReader, CsvReader>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>();
app.Run();









//using MotoApp.Entities;
//using MotoApp.Data;
//using MotoApp.Repositories;
//using MotoApp.Repositories.Extensions;


////var itemAdded = new Action<Employee>(EmployeeAdded);
//var repository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);

////var item2Added = new Action<BusinessPartner>(item => Console.WriteLine($"Business Partner Added => {item.Name}"));
////var businessPartnerRepository = new SqlRepository<BusinessPartner>(new MotoAppDbContext(), item2Added);
//static void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
//{
//    Console.WriteLine($"Employee Added => {e.FirstName}: from {sender?.GetType().Name}");
//}

//AddEmplpoyees(repository);
//WriteAllToConsole(repository);

//static void EmployeeAdded(Employee item)
//{
//    var employee = item;

//    Console.WriteLine($"{item.FirstName}: Employee added");
//}

//static void AddEmplpoyees(IRepository<Employee> repository)
//{
//    if (repository is null)
//    {
//        throw new ArgumentNullException(nameof(repository));
//    }

//    var employees = new[]
//    {
//        new Employee { FirstName = "Adam" },
//        new Employee { FirstName = "Piotr" },
//        new Employee { FirstName = "Zuzanna" },
//    };
//    repository.AddBatch(employees);
//    "cokolwiek".AddBatch(employees);
//}

//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}


