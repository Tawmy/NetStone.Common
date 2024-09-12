namespace NetStone.Common.DTOs.Character;

public record CharacterAchievementOuterDto(
    IEnumerable<CharacterAchievementDto> Achievements,
    bool Cached,
    DateTime? LastUpdated);