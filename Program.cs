using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

var itemAdded = new ItemAdded(EmployeeAdded);
var repository = new SqlRepository<Employee>(new MotoAppDbContext(), itemAdded);
AddEmplpoyees(repository);
WriteAllToConsole(repository);

static void EmployeeAdded(object item)
{
    var employee = (Employee)item;

    Console.WriteLine($"{employee.FirstName}: Employee added");
}


static void AddEmplpoyees(IRepository<Employee> repository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Adam" },
        new Employee { FirstName = "Piotr" },
        new Employee { FirstName = "Zuzanna" }

    };

    repository.AddBatch(employees);
    "cokolwiek".AddBatch(employees);
}


static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}


