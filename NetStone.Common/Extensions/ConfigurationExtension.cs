using Microsoft.Extensions.Configuration;
using NetStone.Common.Exceptions;
using NetStone.Common.Helpers;

namespace NetStone.Common.Extensions;

public static class ConfigurationExtension
{
    public static string GetGuardedConfiguration(this IConfiguration configuration, string key)
    {
        var value = configuration[key];

        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EnvironmentVariableNotSetException(key);
        }

        return value;
    }

    public static T GetGuardedConfiguration<T>(this IConfiguration configuration, string key)
    {
        var valueStr = configuration[key];
        return EnvironmentVariableHelper.ConvertType<T>(key, valueStr);
    }
}