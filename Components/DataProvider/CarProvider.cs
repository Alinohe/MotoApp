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
            

        }).ToList();
        return list;
    }

    public List<int> GetUniqueCity()
    {
        var cars = _carsRepository.GetAll();
        var city = cars.Select(x => x.City).Distinct().ToList();
        return city;
    }

    public List<int> GetUniqueCombined()
    {
      var cars = _carsRepository.GetAll();
        var combined = cars.Select(x => x.Combined).Distinct().ToList();
        return combined;
    }

    public List<int> GetUniqueCylinders()
    {
       var cars = _carsRepository.GetAll();
        var cylinder = cars.Select(x => x.Cylinders).Distinct().ToList();
        return cylinder;
    }

    public List<double> GetUniqueDisplacement()
    {
        var cars = _carsRepository.GetAll();
        var displacement = cars.Select(x => x.Displacement).Distinct().ToList();
        return displacement;
    }

    public List<int> GetUniqueHighway()
    {
       var cars = _carsRepository.GetAll();
        var highway = cars.Select(x => x.Highway).Distinct().ToList();
        return highway;
    }

    public List<string> GetUniqueManufacturer()
    {
        var cars = _carsRepository.GetAll();
        var manufacturer = cars.Select(x => x.Manufacturer).Distinct().ToList();
        return manufacturer;
    }

    public List<string> GetUniqueName()
    {
       var cars = _carsRepository.GetAll();
        var name = cars.Select(x => x.Name).Distinct().ToList();
        return name;
    }

    public List<int> GetUniqueYear()
    {
        var cars = _carsRepository.GetAll();
        var year = cars.Select(x => x.Year).Distinct().ToList();
        return year;
    }


}
