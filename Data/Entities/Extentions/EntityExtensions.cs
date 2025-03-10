namespace MotoApp.Data.Entities.Extentions;

using MotoApp.Data.Entities;
using System.Text.Json;
public static class EntityExtensions
{
    public static T? Copy<T>(this T itemToCopy) where T : IEntity
    {
        var json = JsonSerializer.Serialize(itemToCopy);
        return JsonSerializer.Deserialize<T>(json);
    }
}
