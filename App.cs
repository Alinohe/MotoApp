using MotoApp.Components.CsvReader;
using MotoApp.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace MotoApp;

public class App : IApp
{
    private readonly ICsvReader _csvReader;
    private readonly MotoAppDbContext _motoAppDbContext;
    public App(ICsvReader csvReader, MotoAppDbContext motoAppDbContext)
    {
        _csvReader = csvReader;
        _motoAppDbContext = motoAppDbContext;
        _motoAppDbContext.Database.EnsureCreated(); // Ensure the database is created
    }

    public void Run()
    {
        var cars = _csvReader.ProcessCars("Resources\\fuel.csv");


        //CreateXml();
        //QueryXml();
    }



}










    //private void CreateXml()
    //{
    //    var records = _csvReader.ProcessCars("Resources\\fuel.csv");

    //    var document = new XDocument();
    //    var cars = new XElement("Cars", records
    //        .Select(c =>
    //        new XElement("Car",
    //        new XAttribute("Name", c.Name),
    //        new XAttribute("Combined", c.Combined),
    //        new XAttribute("Manufacturer", c.Manufacturer),
    //        new XAttribute("Year", c.Year))));


    //    document.Add(cars);
    //    document.Save("fuel.xml");

    //}

    //private static void QueryXml()
    //{
    //    var document = XDocument.Load("fuel.xml");
    //    var cars = document.Descendants("Car")
    //        .Select(c => new
    //        {
    //            Name = c.Attribute("Name")?.Value,
    //            Combined = c.Attribute("Combined")?.Value,
    //            Manufacturer = c.Attribute("Manufacturer")?.Value,
    //            Year = c.Attribute("Year")?.Value
    //        });
    //    foreach (var car in cars)
    //    {
    //        Console.WriteLine($"Name: {car.Name}, Combined: {car.Combined}, Manufacturer: {car.Manufacturer}, Year: {car.Year}");
    //    }

    //}
   // ..........................................................................................
        //var manufacturers = _csvReader.ProcessManufacturers("Resources\\manufacturers.csv");

    //var groups = manufacturers.GroupJoin(
    //    cars,
    //    m => m.Name,
    //    c => c.Manufacturer,
    //    (m, g) => new
    //    {
    //        Manufacturer = m,
    //        Cars = g
    //    })
    //    .OrderBy(m => m.Manufacturer.Name);

    //foreach (var group in groups)
    //{
    //    Console.WriteLine($"Manufacturer:{group.Manufacturer.Name}");
    //    Console.WriteLine($"\t Cars: {group.Cars.Count()}");
    //    Console.WriteLine($"\t Max: {group.Cars.Max(c => c.Combined)}");
    //    Console.WriteLine($"\t Min: {group.Cars.Min(c => c.Combined)}");
    //    Console.WriteLine($"\t Average: {group.Cars.Average(c => c.Combined)}");
    //    Console.WriteLine();
    //}












