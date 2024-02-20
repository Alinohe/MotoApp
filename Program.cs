using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmplpoyees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmplpoyees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Adam" });
    employeeRepository.Add(new Employee { FirstName = "Piots" });
    employeeRepository.Add(new Employee { FirstName = "Zuzanna" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Manager> employeeRepository)
{
    employeeRepository.Add(new Manager { FirstName = "Przemek" });
    employeeRepository.Add(new Manager { FirstName = "Tomek" });
    employeeRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach(var item  in items)
    {
        Console.WriteLine(item);
    }
}