namespace NetStone.Common.DTOs.Character;

public record CharacterAchievementOuterDtoV2(
    IEnumerable<CharacterAchievementDto> Achievements,
    bool Cached,
    DateTime? LastUpdated) : ICachingDtoV2;