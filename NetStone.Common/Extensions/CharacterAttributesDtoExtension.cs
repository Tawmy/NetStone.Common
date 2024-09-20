using NetStone.Common.DTOs.Character;
using NetStone.Common.Enums;

namespace NetStone.Common.Extensions;

public static class CharacterAttributesDtoExtension
{
    public static IDictionary<CharacterAttribute, int?> ToAttributeDictionary(this CharacterAttributesDto dto)
    {
        var dict = new Dictionary<CharacterAttribute, int?>();

        foreach (var characterAttribute in Enum.GetValues<CharacterAttribute>())
        {
            if (typeof(CharacterAttributesDto).GetProperty(characterAttribute.ToString()) is not { } propInfo)
            {
                continue;
            }

            var propValue = propInfo.GetValue(dto) as int?;
            dict.Add(characterAttribute, propValue);
        }

        return dict;
    }
}