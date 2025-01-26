namespace MotoApp.Repositories.Extensions;
using MotoApp.Entities;
using System.Runtime.CompilerServices;

public static class RepositoryExtensions
{
    public static void AddBatch<T>(IRepository<T> repository, T[] items)
        where T : class, IEntity
    {
        foreach (var item in items)
        {
            repository.Add(item);
        }
        repository.Save();

    }

    public static void AddBatch<T>(this string str, T[] items)
        where T : class, IEntity
    {

    }
}
