using System.ComponentModel.DataAnnotations;

namespace NetStone.Common.Enums;

public enum Tribe
{
    #region Hyur

    Midlander,
    Highlander,

    #endregion

    #region Elezen

    Wildwood,
    Duskwight,

    #endregion

    #region Lalafell

    Plainsfolk,
    Dunesfolk,

    #endregion

    #region Miqo'te

    [Display(Name = "Seeker of the Sun")] SeekerOfTheSun,
    [Display(Name = "Keeper of the Moon")] KeeperOfTheMoon,

    #endregion

    #region Roegadyn

    [Display(Name = "Sea Wolf")] SeaWolf,
    Hellsguard,

    #endregion

    #region Au Ra

    Raen,
    Xaela,

    #endregion

    #region Hrothgar

    Helions,
    [Display(Name = "The Lost")] TheLost,

    #endregion

    #region Viera

    Rava,
    Veena,

    #endregion
}