using System.Text;
using MotoApp.Components.DataProvider.Extensions;
using MotoApp.Data.Entities;
using MotoApp.Data.Repositories;

namespace MotoApp.Components.DataProvider;

public class CarProvider : ICarProvider
{
    private readonly IRepository<Car> _carsRepository;
    public CarProvider(IRepository<Car> carsRepository)
    {
        _carsRepository = carsRepository;
    }

    public List<Car> GetSpecificColumns()
    {
        var cars = _carsRepository.GetAll();
        var list = cars.Select(cars => new Car
        {
            Id = cars.Id,
            Make = cars.Make,
            Model = cars.Model,
            Type = cars.Type,
        }).ToList();
        return list;
    }

    public List<string> GetUniqueCarColours()
    {
        var cars = _carsRepository.GetAll();
        var colours = cars.Select(x => x.Colour).Distinct().ToList();
        return colours;
    }

    public decimal GetMinimumPriceOfAllCars()
    {
        var cars = _carsRepository.GetAll();
        return cars.Select(x => x.ListPrice).Min();
    }

    public string AnonymousClass()
    {
        var cars = _carsRepository.GetAll();
        var list = cars.Select(car => new
        {
            NewId = car.Id,
            NewMake = car.Make,
            NewModel = car.Model,
            NewType = car.Type,
        }).ToList();

        StringBuilder sb = new(2048);
        foreach (var car in list)
        {
            sb.AppendLine($"Product ID: {car.NewId}");
            sb.AppendLine($"Make: {car.NewMake}");
            sb.AppendLine($"Model: {car.NewModel}");
            sb.AppendLine($"Type: {car.NewType}");
            // result += $"Id: {car.Id}, Make: {car.Make}, Model: {car.Model}, Type: {car.Type}\n";
        }
        return sb.ToString();

    }

    public List<Car> FilterCars(decimal minPrice)
    {
        var cars = _carsRepository.GetAll();
        var list = new List<Car>();

        foreach (var car in cars)
        {
            if (car.ListPrice > minPrice)
            {
                list.Add(car);
            }
        }
        return list;
    }

    public List<Car> OrderByMake()
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).ToList();
    }

    public List<Car> OrderByMakeDesc()
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderByDescending(x => x.Make).ToList();
    }

    public List<Car> OrderByColourAndMake()
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Colour).ThenBy(x => x.Make).ToList();
    }

    public List<Car> OrderByColourAndMakeDesc()
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderByDescending(x => x.Colour).ThenByDescending(x => x.Make).ToList();
    }


    public List<Car> WhereStrartsWith(string prefix)
    {
        var cars = _carsRepository.GetAll();
        return cars.Where(x => x.Make.StartsWith(prefix)).ToList();
    }

    public List<Car> WhereStrartsWithAndCostIsGreaterThan(string prefix, decimal cost)
    {
        var cars = _carsRepository.GetAll();
        return cars.Where(x => x.Make.StartsWith(prefix) && x.StandardCost > cost).ToList();
    }

    public List<Car> WhereColourIs(string colour)
    {
        var cars = _carsRepository.GetAll();
        return cars.ByColour("Red").ToList();
    }

    //First Last Single

    public Car FirstByColour(string colour)
    {
        var cars = _carsRepository.GetAll();
        return cars.First(x => x.Colour == colour);
    }

    public Car? FirstOrDefaultByColour(string colour)
    {
        var cars = _carsRepository.GetAll();
        return cars.FirstOrDefault(x => x.Colour == colour);
    }

    public Car? FirstOrDefaultByColourWithDefault(string colour)
    {
        var cars = _carsRepository.GetAll();
        return cars.FirstOrDefault(x => x.Colour == colour, new Car { Id = -1, Make = "Not Found" });
    }

    public Car LastByColour(string colour)
    {
        var cars = _carsRepository.GetAll();
        return cars.Last(x => x.Colour == colour);
    }

    public Car SingleById(int id)
    {
        var cars = _carsRepository.GetAll();
        return cars.Single(x => x.Id == id);
    }

    public Car? SingleOrDefaultById(int id)
    {
        var cars = _carsRepository.GetAll();
        return cars.SingleOrDefault(x => x.Id == id);
    }

    public List<Car> TakeCars(int howMany)
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).Take(howMany).ToList();
    }

    public List<Car> TakeCars(Range range)
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).Take(range).ToList(); //range is a struct fe 1..3
    }

    public List<Car> TakeCarsWhileNameStartsWith(string prefix)
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).TakeWhile(x => x.Make.StartsWith(prefix)).ToList();
    }

    public List<Car> SkipCars(int howMany)
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).Skip(howMany).ToList();
    }

    public List<Car> SkipCarsWhileMakeStartsWith(string prefix)
    {
        var cars = _carsRepository.GetAll();
        return cars.OrderBy(x => x.Make).SkipWhile(x => x.Make.StartsWith(prefix)).ToList();
    }

    public List<string> DistinctAllColours()
    {
        var cars = _carsRepository.GetAll();
        return cars.Select(x => x.Colour).Distinct().OrderBy(c => c).ToList();
    }

    public List<Car> DistinctByColours()
    {
        var cars = _carsRepository.GetAll();
        return cars.DistinctBy(x => x.Colour).OrderBy(x => x.Colour).ToList();
    }

    public List<Car[]> ChunkCars(int size)
    {
        var cars = _carsRepository.GetAll();
        return cars.Chunk(size).ToList();
    }
}
