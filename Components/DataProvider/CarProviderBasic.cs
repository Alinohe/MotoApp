﻿
//using MotoApp.Entities;
//using MotoApp.Repositories;

//namespace MotoApp.DataProvider;

//public class CarProviderBasic : ICarProvider    
//{
//    private readonly IRepository<Car> _carsRepository;  
//    public CarProviderBasic(IRepository<Car> carsRepository) 
//    {
//        _carsRepository = carsRepository;
//    }
//    public List<Car> FilterCars(decimal minPrice)
//    {
//        var cars = _carsRepository.GetAll();
//        var list = new List<Car>();

//        foreach (var car in cars)
//        {
//            if(car.ListPrice > minPrice)
//            {
//                list.Add(car);
//            }
//        }
//        return list;
//    }

//    public decimal GetMinimumPriceOfAllCars()
//    {
//        throw new NotImplementedException();
//    }

//    public List<string> GetUniqueCarColors()
//    {
//        throw new NotImplementedException();
//    }
//}
