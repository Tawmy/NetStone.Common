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
}