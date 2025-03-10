using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProvider.Extensions;

public static class CarsHelper
{
    public static IEnumerable<Car> ByColour(this IEnumerable<Car> query, string color)
    {
        return query.Where(c => c.Colour == color);
    }

}
