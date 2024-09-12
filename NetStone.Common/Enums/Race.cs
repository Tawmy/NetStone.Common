using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Race
{
    Hyur,
    Elezen,
    Lalafell,
    [Display(Name = "Miqo'te")] Miqote,
    Roegadyn,
    [Display(Name = "Au Ra")] AuRa,
    Hrothgar,
    Viera
}