using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProvider;

public interface ICarProvider
{
    //select
    List<Car> GetSpecificColumns();
    List<string> GetUniqueCarColours();
    decimal GetMinimumPriceOfAllCars();
    string AnonymousClass();
    List<Car> FilterCars(decimal minPrice);

    //order by
    List<Car> OrderByMake();

    List<Car> OrderByMakeDesc();

    List<Car> OrderByColourAndMake();

    List<Car> OrderByColourAndMakeDesc();

    //where
    List<Car> WhereStrartsWith(string prefix);

    List<Car> WhereStrartsWithAndCostIsGreaterThan(string prefix, decimal cost);

    List<Car> WhereColourIs(string colour);

    //first last single

    Car FirstByColour(string colour);

    Car FirstOrDefaultByColour(string colour);

    Car? FirstOrDefaultByColourWithDefault(string colour);

    Car LastByColour(string colour);

    Car SingleById(int id);

    Car? SingleOrDefaultById(int id);

    //Take

    List<Car> TakeCars(int howMany);
    List<Car> TakeCars(Range range);
    List<Car> TakeCarsWhileNameStartsWith(string prefix);

    //Skip

    List<Car> SkipCars(int howMany);

    List<Car> SkipCarsWhileMakeStartsWith(string prefix);

    //Distinct
    List<string> DistinctAllColours();

    List<Car> DistinctByColours();

    //Chunk

    List<Car[]> ChunkCars(int size);

}
