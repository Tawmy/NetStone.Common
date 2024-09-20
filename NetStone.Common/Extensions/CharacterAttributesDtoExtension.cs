using NetStone.Common.DTOs.Character;
using NetStone.Common.Enums;

namespace NetStone.Common.Extensions;

public static class CharacterAttributesDtoExtension
{
    public static IDictionary<CharacterAttribute, int?> ToAttributeDictionary(this CharacterAttributesDto dto,
        ClassJob activeClassJob)
    {
        var dict = new Dictionary<CharacterAttribute, int?>
        {
            { CharacterAttribute.Hp, dto.Hp },

            { CharacterAttribute.Strength, dto.Strength },
            { CharacterAttribute.Dexterity, dto.Dexterity },
            { CharacterAttribute.Vitality, dto.Vitality },
            { CharacterAttribute.Intelligence, dto.Intelligence },
            { CharacterAttribute.Mind, dto.Mind },

            { CharacterAttribute.CriticalHitRate, dto.CriticalHitRate },
            { CharacterAttribute.Determination, dto.Determination },
            { CharacterAttribute.DirectHitRate, dto.DirectHitRate },

            { CharacterAttribute.Defense, dto.Defense },
            { CharacterAttribute.MagicDefense, dto.MagicDefense },

            { CharacterAttribute.AttackPower, dto.AttackPower },
            { CharacterAttribute.SkillSpeed, dto.SkillSpeed }
        };

        if (activeClassJob.IsDiscipleOfHand())
        {
            dict.Add(CharacterAttribute.Cp, dto.MpGpCp);

            dict.Add(CharacterAttribute.Craftmanship, dto.AttackMagicPotency);
            dict.Add(CharacterAttribute.Control, dto.HealingMagicPotency);
        }
        else if (activeClassJob.IsDiscipleOfLand())
        {
            dict.Add(CharacterAttribute.Gp, dto.MpGpCp);

            dict.Add(CharacterAttribute.Gathering, dto.AttackMagicPotency);
            dict.Add(CharacterAttribute.Perception, dto.HealingMagicPotency);
        }
        else
        {
            dict.Add(CharacterAttribute.Mp, dto.MpGpCp);

            dict.Add(CharacterAttribute.AttackMagicPotency, dto.AttackMagicPotency);
            dict.Add(CharacterAttribute.HealingMagicPotency, dto.HealingMagicPotency);
            dict.Add(CharacterAttribute.SpellSpeed, dto.SpellSpeed);

            dict.Add(CharacterAttribute.Tenacity, dto.Tenacity);
            dict.Add(CharacterAttribute.Piety, dto.Piety);
        }

        return dict;
    }
}