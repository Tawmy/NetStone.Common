namespace NetStone.Common.DTOs.Character;

public record CharacterGearDyeDto
{
    public required string Name { get; init; }
    public required string Color { get; init; }
    public required string DatabaseLink { get; init; }
}