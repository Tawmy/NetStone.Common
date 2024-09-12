namespace NetStone.Common.DTOs.Character;

public record CharacterAchievementDto
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public required Uri DatabaseLink { get; init; }
    public required DateTime TimeAchieved { get; init; }
}