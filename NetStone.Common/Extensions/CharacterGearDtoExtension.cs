using NetStone.Common.DTOs.Character;
using NetStone.Common.Enums;

namespace NetStone.Common.Extensions;

public static class CharacterGearDtoExtension
{
    public static int GetAvarageItemLevel(this ICollection<CharacterGearDto> dtos)
    {
        var totalItemlevel = 0;

        foreach (var slot in Enum.GetValues<GearSlot>())
        {
            if (dtos.FirstOrDefault(x => x.Slot == slot) is not { } slotItem)
            {
                continue;
            }

            if (slotItem.Slot == GearSlot.MainHand && dtos.All(x => x.Slot != GearSlot.OffHand))
            {
                // if no off-hand equipped, count main hand twice
                totalItemlevel += slotItem.ItemLevel * 2;
            }
            else
            {
                totalItemlevel += slotItem.ItemLevel;
            }
        }

        return (int)decimal.Divide(totalItemlevel, 12);
    }
}