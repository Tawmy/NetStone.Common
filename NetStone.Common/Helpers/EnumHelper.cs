using NetStone.Common.Extensions;

namespace NetStone.Common.Helpers;

public static class EnumHelper
{
    public static T ParseFromDisplayString<T>(string value) where T : Enum
    {
        foreach (T enumValue in Enum.GetValues(typeof(T)))
        {
            var enumStr = enumValue.TryGetDisplayName(out var displayName) ? displayName! : enumValue.ToString();
            if (enumStr == value)
            {
                return enumValue;
            }
        }

        throw new ArgumentOutOfRangeException(nameof(value), value, "Enum value not found");
    }
}