namespace NetStone.Common.DTOs.Character;

public record CharacterAchievementOuterDtoV3(
    IEnumerable<CharacterAchievementDto> Achievements,
    bool Cached,
    DateTime? LastUpdated,
    bool FallbackUsed = false,
    string? FallbackReason = null)
    : ICachingDtoV3;