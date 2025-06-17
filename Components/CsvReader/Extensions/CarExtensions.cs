using MotoApp.Components.CsvReader.Models;
using System.Globalization;

namespace MotoApp.Components.CsvReader.Extensions;

public static class CarExtensions
{
    public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
    {
        foreach (var line in source)
        {
            var col = line.Split(',');

            yield return new Car
            {
                Year = int.Parse(col[0]),
                Manufacturer = col[1],
                Name = col[2],
                Displacement = double.Parse(col[3]),
                Cylinders = int.Parse(col[4]),
                City = int.Parse(col[5]),
                Highway = int.Parse(col[6]),
                Combined = int.Parse(col[7])

            };
        }
      
    }
}
