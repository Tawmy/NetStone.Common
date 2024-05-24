using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GearSlot
{
    MainHand,
    OffHand,
    Head,
    Body,
    Hands,
    Legs,
    Feet,
    Earrings,
    Necklace,
    Bracelets,
    Ring1,
    Ring2,
    SoulCrystal
}