using System.Collections.Concurrent;
using System.Reflection;
using ApplicationCore.Databases.Annotations;
using ApplicationCore.Databases.Definitions;

namespace Application.Utilities;

public static class EntityUtility
{
    private static readonly ConcurrentDictionary<Type, string> NamesCache = new();
    private static readonly ConcurrentDictionary<Type, string> TableNamesCache = new();
    private static readonly ConcurrentDictionary<Type, string> TargetNamesCache = new();
    private static readonly ConcurrentDictionary<Type, IEnumerable<string>> ColumnNamesCache = new();

    public static string Name<T>() where T : class, new()
    {
        return NamesCache.GetOrAdd(typeof(T), _ =>
        {
            var dataObject = new T().GetCustomAttribute<DataObjectAttribute>();
            return $"\"{dataObject.Name ?? typeof(T).Name}\"";
        });
    }

    public static string TableName<T>() where T : class, new()
    {
        return TableNamesCache.GetOrAdd(typeof(T), _ =>
        {
            var dataObject = new T().GetCustomAttribute<DataObjectAttribute>();
            if (!string.IsNullOrWhiteSpace(dataObject.Prefix)) dataObject.Prefix = $"{dataObject.Prefix}" + TablePrefix.Link;
            return $"\"{dataObject.Prefix}{dataObject.Name ?? typeof(T).Name}\"";
        });
    }

    public static string TargetName<T>(string? schema = null) where T : class, new()
    {
        return TargetNamesCache.GetOrAdd(typeof(T), _ =>
        {
            var dataObject = new T().GetCustomAttribute<DataObjectAttribute>();
            if (!string.IsNullOrWhiteSpace(dataObject.Schema)) schema = $"\"{dataObject.Schema}\".";
            if (!string.IsNullOrWhiteSpace(dataObject.Prefix)) dataObject.Prefix = $"{dataObject.Prefix}" + TablePrefix.Link;
            return schema + $"\"{dataObject.Prefix}{dataObject.Name ?? typeof(T).Name}\"";
        });
    }

    public static IEnumerable<string> GetColumnNames<T>()
    {
        return ColumnNamesCache.GetOrAdd(typeof(T), type =>
        {
            var columnNames = new List<string>();
#if (ENABLE_ENTITY_FIELD)
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    columnNames.Add(field.Name);
                }
#endif
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                columnNames.Add(property.Name);
            }
            return columnNames;
        });
    }
}