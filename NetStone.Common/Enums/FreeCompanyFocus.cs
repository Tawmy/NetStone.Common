using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FreeCompanyFocus
{
    NotSpecified = 0,
    [Display(Name = "Role Playing")] RolePlay = 1,
    Leveling = 1 << 1,
    Casual = 1 << 2,
    Hardcore = 1 << 3,
    Dungeons = 1 << 4,
    Guildhests = 1 << 5,
    Trials = 1 << 6,
    Raids = 1 << 7,
    PvP = 1 << 8
}