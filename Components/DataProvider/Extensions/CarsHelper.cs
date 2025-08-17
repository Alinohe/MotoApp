using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProvider.Extensions;

public static class CarsHelper
{
    public static IEnumerable<Car> ByName(this IEnumerable<Car> query, string name)
    {
        return query.Where(c => c.Name == name);
    }

}
