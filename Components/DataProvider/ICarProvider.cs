using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProvider;

public interface ICarProvider
{
    //select
    List<Car> GetSpecificColumns();
    List<int> GetUniqueYear();
    List<string> GetUniqueManufacturer();
    List<string> GetUniqueName();
    List<double> GetUniqueDisplacement();   
    List<int> GetUniqueCylinders();
    List<int> GetUniqueCity();
    List<int> GetUniqueHighway();
    List<int> GetUniqueCombined();

    //order by



}
