using NetStone.Common.Enums;

namespace NetStone.Common.Extensions;

public static class ClassJobExtension
{
    public static bool EvolvesFromClass(this ClassJob classJob)
    {
        return classJob switch
        {
            ClassJob.Paladin or
                ClassJob.Warrior or
                ClassJob.Monk or
                ClassJob.Dragoon or
                ClassJob.Bard or
                ClassJob.WhiteMage or
                ClassJob.BlackMage or
                ClassJob.Summoner or
                ClassJob.Scholar or
                ClassJob.Ninja => true,
            _ => false
        };
    }

    public static bool EvolvesIntoJob(this ClassJob classJob)
    {
        return classJob switch
        {
            ClassJob.Gladiator or
                ClassJob.Marauder or
                ClassJob.Pugilist or
                ClassJob.Lancer or
                ClassJob.Archer or
                ClassJob.Conjurer or
                ClassJob.Thaumaturge or
                ClassJob.Arcanist or
                ClassJob.Rogue => true,
            _ => false
        };
    }

    public static ClassJob? GetClass(this ClassJob classJob)
    {
        return classJob switch
        {
            ClassJob.Paladin => ClassJob.Gladiator,
            ClassJob.Monk => ClassJob.Pugilist,
            ClassJob.Warrior => ClassJob.Marauder,
            ClassJob.Dragoon => ClassJob.Lancer,
            ClassJob.Bard => ClassJob.Archer,
            ClassJob.WhiteMage => ClassJob.Conjurer,
            ClassJob.BlackMage => ClassJob.Thaumaturge,
            ClassJob.Summoner => ClassJob.Arcanist,
            ClassJob.Scholar => ClassJob.Arcanist,
            ClassJob.Ninja => ClassJob.Rogue,
            _ => null
        };
    }

    /// <summary>
    ///     Returns primary and secondary attributes for jobs.
    /// </summary>
    /// <remarks>
    ///     Crafters and gatherers do not have any primary attributes, so only secondary ones are returned for them.
    /// </remarks>
    /// <param name="job">The job to get attributes for.</param>
    /// <returns>A collection of attributes, primary then secondary.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Job not implemented.</exception>
    public static ICollection<CharacterAttribute> GetDisplayAttributes(this ClassJob job)
    {
        return job switch
        {
            ClassJob.Gladiator or ClassJob.Paladin or ClassJob.Marauder or ClassJob.Warrior or ClassJob.DarkKnight
                or ClassJob.Gunbreaker =>
                [
                    CharacterAttribute.Strength,
                    CharacterAttribute.Vitality,
                    CharacterAttribute.CriticalHitRate,
                    CharacterAttribute.Determination,
                    CharacterAttribute.Tenacity
                ],
            ClassJob.Conjurer or ClassJob.WhiteMage or ClassJob.Scholar or ClassJob.Astrologian or ClassJob.Sage =>
            [
                CharacterAttribute.Mind,
                CharacterAttribute.Vitality,
                CharacterAttribute.CriticalHitRate,
                CharacterAttribute.DirectHitRate,
                CharacterAttribute.Determination
            ],
            ClassJob.Pugilist or ClassJob.Monk or ClassJob.Lancer or ClassJob.Dragoon or ClassJob.Rogue
                or ClassJob.Samurai or ClassJob.Reaper =>
                [
                    CharacterAttribute.Strength,
                    CharacterAttribute.Vitality,
                    CharacterAttribute.CriticalHitRate,
                    CharacterAttribute.Determination,
                    CharacterAttribute.DirectHitRate
                ],
            ClassJob.Archer or ClassJob.Bard or ClassJob.Machinist or ClassJob.Dancer or ClassJob.Ninja
                or ClassJob.Viper =>
                [
                    CharacterAttribute.Dexterity,
                    CharacterAttribute.Vitality,
                    CharacterAttribute.CriticalHitRate,
                    CharacterAttribute.Determination,
                    CharacterAttribute.DirectHitRate
                ],
            ClassJob.Thaumaturge or ClassJob.BlackMage or ClassJob.Arcanist or ClassJob.Summoner or ClassJob.RedMage
                or ClassJob.Pictomancer or ClassJob.BlueMage =>
                [
                    CharacterAttribute.Intelligence,
                    CharacterAttribute.Vitality,
                    CharacterAttribute.CriticalHitRate,
                    CharacterAttribute.Determination,
                    CharacterAttribute.DirectHitRate
                ],
            ClassJob.Carpenter or ClassJob.Blacksmith or ClassJob.Armorer or ClassJob.Goldsmith
                or ClassJob.Leatherworker or ClassJob.Weaver or ClassJob.Alchemist or ClassJob.Culinarian =>
                [
                    CharacterAttribute.Craftmanship,
                    CharacterAttribute.Control,
                    CharacterAttribute.Cp
                ],
            ClassJob.Miner or ClassJob.Botanist or ClassJob.Fisher =>
            [
                CharacterAttribute.Gathering,
                CharacterAttribute.Perception,
                CharacterAttribute.Gp
            ],
            _ => throw new ArgumentOutOfRangeException(nameof(job), job, "Job not implemented")
        };
    }

    public static bool IsDiscipleOfHand(this ClassJob classJob)
    {
        return classJob is ClassJob.Carpenter or ClassJob.Blacksmith or ClassJob.Armorer or ClassJob.Goldsmith
            or ClassJob.Leatherworker or ClassJob.Weaver or ClassJob.Alchemist or ClassJob.Culinarian;
    }

    public static bool IsDiscipleOfLand(this ClassJob classJob)
    {
        return classJob is ClassJob.Miner or ClassJob.Botanist or ClassJob.Fisher;
    }
}