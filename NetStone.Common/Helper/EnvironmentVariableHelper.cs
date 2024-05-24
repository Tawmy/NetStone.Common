using NetStone.Common.Exceptions;

namespace NetStone.Common.Helper;

public static class EnvironmentVariableHelper
{
    public static string Get(string key)
    {
        var val = Environment.GetEnvironmentVariable(key);

        if (val is null)
        {
            throw new EnvironmentVariableNotSetException(key);
        }

        return val;
    }

    public static T Get<T>(string key)
    {
        var valueStr = Environment.GetEnvironmentVariable(key);
        return ConvertType<T>(key, valueStr);
    }

    internal static T ConvertType<T>(string key, string? valueStr)
    {
        if (valueStr is null)
        {
            throw new EnvironmentVariableNotSetException(key);
        }

        object? value;

        if (typeof(T) == typeof(int))
        {
            value = int.Parse(valueStr);
        }
        else if (typeof(T) == typeof(Uri))
        {
            value = new Uri(valueStr);
        }
        else
        {
            throw new NotImplementedException($"Type {typeof(T).FullName} conversion not implemented.");
        }

        return (T)Convert.ChangeType(value, typeof(T));
    }
}