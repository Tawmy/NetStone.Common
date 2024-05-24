using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GrandCompany
{
    [Display(Name = "")] NoAffiliation,

    [Display(Name = "The Maelstrom")] Maelstrom,

    [Display(Name = "The Order of the Twin Adder")]
    OrderOfTheTwinAdder,

    [Display(Name = "The Immortal Flames")]
    ImmortalFlames
}