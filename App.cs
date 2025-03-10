namespace MotoApp;
using MotoApp.Components.DataProvider;
using MotoApp.Data.Entities;
using MotoApp.Data.Repositories;

public class App : IApp
{
    private readonly IRepository<Employee> _employeeRepository;
    private readonly IRepository<Car> _carsRepository;
    private readonly ICarProvider _carsProvider;

    public App(
        IRepository<Employee> employeeRepository,
        IRepository<Car> carsRepository,
        ICarProvider carsProvider)
    {
        _employeeRepository = employeeRepository;
        _carsRepository = carsRepository;
        _carsProvider = carsProvider;
    }
    public void Run()
    {
        Console.WriteLine("Im here Run() method");

        var employee = new[]
        {
            new Employee { FirstName = "Adam" },
            new Employee { FirstName = "Piotr" },
            new Employee { FirstName = "Zuzanna" },
        };

        foreach (var emp in employee)
        {
            _employeeRepository.Add(emp);
        }
        _employeeRepository.Save();
        //reading
        var items = _employeeRepository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        //Cars
        var cars = GenerateSampleCars();
        foreach (var car in cars)
        {
            _carsRepository.Add(car);
        }

        Console.WriteLine();
        Console.WriteLine("Unique Car Colours");
        foreach (var car in _carsProvider.GetUniqueCarColours())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("Minimum Price of All Cars");
        Console.WriteLine(_carsProvider.GetMinimumPriceOfAllCars());

        Console.WriteLine();
        Console.WriteLine("GetSpecificColumnsMethod");
        foreach (var car in _carsProvider.GetSpecificColumns())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("AnonymousClassInString");
        Console.WriteLine(_carsProvider.AnonymousClass());

        Console.WriteLine();
        Console.WriteLine("OrderByMake");
        foreach (var car in _carsProvider.OrderByMake())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByMakeDescending");
        foreach (var car in _carsProvider.OrderByMakeDesc())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByColourAndMake");
        foreach (var car in _carsProvider.OrderByColourAndMake())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByColourAndMakeDescending");
        foreach (var car in _carsProvider.OrderByColourAndMakeDesc())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("WhereStrartsWith A");
        foreach (var car in _carsProvider.WhereStrartsWith("A"))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("WhereStrartsWithAndCostIsGreaterThan A 20000");
        foreach (var car in _carsProvider.WhereStrartsWithAndCostIsGreaterThan("A", 20000))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("WhereColourIs Black");
        foreach (var car in _carsProvider.WhereColourIs("Black"))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("FirstOrDefaultByColour");
        Console.WriteLine(_carsProvider.FirstOrDefaultByColour("Black"));

        Console.WriteLine();
        Console.WriteLine("LastByColour");
        Console.WriteLine(_carsProvider.LastByColour("Black"));

        Console.WriteLine();
        Console.WriteLine("SingleById 4");
        Console.WriteLine(_carsProvider.SingleById(4));

        Console.WriteLine();
        Console.WriteLine("SingleOrDefaultById 3");
        Console.WriteLine(_carsProvider.SingleOrDefaultById(3));

        Console.WriteLine();
        Console.WriteLine("TakeCars");
        foreach (var car in _carsProvider.TakeCars(3))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("TakeCars Range");
        foreach (var car in _carsProvider.TakeCars(new Range(1, 3)))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("TakeCarsWhileNameStartsWith  T");
        foreach (var car in _carsProvider.TakeCarsWhileNameStartsWith("T"))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("DistinctAllColours");
        foreach (var car in _carsProvider.DistinctAllColours())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("DistinctByColours");
        foreach (var car in _carsProvider.DistinctByColours())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("ChunkCars");
        foreach (var car in _carsProvider.ChunkCars(3))
        {
            Console.WriteLine($"Chunk");
            foreach (var i in car)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("######");
        }

        Console.WriteLine();
        Console.WriteLine("SkipCars");
        foreach (var car in _carsProvider.SkipCars(3))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("SkipCarsWhileMakeStartsWith F");
        foreach (var car in _carsProvider.SkipCarsWhileMakeStartsWith("F"))
        {
            Console.WriteLine(car);
        }

    }


    public static List<Car> GenerateSampleCars()
    {
        return new List<Car>
        {
            new Car {Id = 201, Make = "Toyota", Model = "Corolla", Colour = "Blue",
                StandardCost = 12000, ListPrice = 15000, Year = 2018 },
            new Car {Id = 202, Make = "Toyota", Model = "Camry", Colour = "Red",
                StandardCost = 15000, ListPrice = 18000, Year = 2019 },
            new Car {Id = 203, Make = "Toyota", Model = "Prius", Colour = "Green",
                StandardCost = 20000, ListPrice = 25000, Year = 2020 },
            new Car {Id = 204, Make = "Toyota", Model = "Highlander", Colour = "Black",
                StandardCost = 25000, ListPrice = 30000, Year = 2021 },
            new Car {Id = 205, Make = "Ford", Model = "Galaxy", Colour = "White",
                StandardCost = 30000, ListPrice = 35000, Year = 2022 },
            new Car {Id = 206, Make = "Ford", Model = "Focus", Colour = "Yellow",
                StandardCost = 35000, ListPrice = 40000, Year = 2023 },
            new Car {Id = 207, Make = "Ford", Model = "Fiesta", Colour = "Orange",
                StandardCost = 40000, ListPrice = 45000, Year = 2024 },
            new Car {Id = 208, Make = "Audi", Model = "A8L", Colour = "Purple",
                StandardCost = 45000, ListPrice = 50000, Year = 2025 },
            new Car {Id = 209, Make = "Audi", Model = "A6", Colour = "Black",
                StandardCost = 50000, ListPrice = 55000, Year = 2026 },


        };
    }
}