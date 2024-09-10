using System.ComponentModel.DataAnnotations;

namespace NetStone.Common.Enums;

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