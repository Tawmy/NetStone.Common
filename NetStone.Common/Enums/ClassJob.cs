using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ClassJob
{
    #region A Realm Reborn

    [Display(ShortName = "GLA")] Gladiator,
    [Display(ShortName = "PGL")] Pugilist,
    [Display(ShortName = "MRD")] Marauder,
    [Display(ShortName = "LNC")] Lancer,
    [Display(ShortName = "ARC")] Archer,
    [Display(ShortName = "CNJ")] Conjurer,
    [Display(ShortName = "THM")] Thaumaturge,
    [Display(ShortName = "CRP")] Carpenter,
    [Display(ShortName = "BSM")] Blacksmith,
    [Display(ShortName = "ARM")] Armorer,
    [Display(ShortName = "GSM")] Goldsmith,
    [Display(ShortName = "LTW")] Leatherworker,
    [Display(ShortName = "WVR")] Weaver,
    [Display(ShortName = "ALC")] Alchemist,
    [Display(ShortName = "CUL")] Culinarian,
    [Display(ShortName = "MIN")] Miner,
    [Display(ShortName = "BTN")] Botanist,
    [Display(ShortName = "FSH")] Fisher,
    [Display(ShortName = "PLD")] Paladin,
    [Display(ShortName = "MNK")] Monk,
    [Display(ShortName = "WAR")] Warrior,
    [Display(ShortName = "DRG")] Dragoon,
    [Display(ShortName = "BRD")] Bard,
    [Display(ShortName = "WHM")] WhiteMage,
    [Display(ShortName = "BLM")] BlackMage,
    [Display(ShortName = "ACN")] Arcanist,
    [Display(ShortName = "SMN")] Summoner,
    [Display(ShortName = "SCH")] Scholar,
    [Display(ShortName = "ROG")] Rogue,
    [Display(ShortName = "NIN")] Ninja,

    #endregion

    #region Heavensward

    [Display(ShortName = "MCH")] Machinist,
    [Display(ShortName = "DRK")] DarkKnight,
    [Display(ShortName = "AST")] Astrologian,

    #endregion

    #region Stormblood

    [Display(ShortName = "SAM")] Samurai,
    [Display(ShortName = "RDM")] RedMage,
    [Display(ShortName = "BLU")] BlueMage,

    #endregion

    #region Shadowbringers

    [Display(ShortName = "GNB")] Gunbreaker,
    [Display(ShortName = "DNC")] Dancer,

    #endregion

    #region Endwalker

    [Display(ShortName = "RPR")] Reaper,
    [Display(ShortName = "SGE")] Sage,

    #endregion

    #region Dawntrail

    [Display(ShortName = "VPR")] Viper,
    [Display(ShortName = "PCT")] Pictomancer

    #endregion
}