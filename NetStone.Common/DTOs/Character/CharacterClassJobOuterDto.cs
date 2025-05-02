using NetStone.Common.Enums;

namespace NetStone.Common.DTOs.Character;

public record CharacterClassJobOuterDto(
    ICollection<CharacterClassJobDto> Unlocked,
    bool Cached,
    DateTime? LastUpdated,
    bool FallbackUsed = false,
    string? FallbackReason = null) : ICachingDto
{
    // ReSharper disable once RedundantExplicitPositionalPropertyDeclaration
    // Need a specific order for these properties
    public ICollection<CharacterClassJobDto> Unlocked { get; init; } = Unlocked;

    public IEnumerable<ClassJob> Locked { get; } =
        Enum.GetValues<ClassJob>().Where(x => !Unlocked.Select(y => y.ClassJob).Contains(x));

    // ReSharper disable once RedundantExplicitPositionalPropertyDeclaration
    // Need a specific order for these properties
    public bool Cached { get; init; } = Cached;

    // ReSharper disable once RedundantExplicitPositionalPropertyDeclaration
    // Need a specific order for these properties
    public DateTime? LastUpdated { get; init; } = LastUpdated;

    // ReSharper disable once RedundantExplicitPositionalPropertyDeclaration
    // Need a specific order for these properties
    public bool FallbackUsed { get; init; } = FallbackUsed;

    // ReSharper disable once RedundantExplicitPositionalPropertyDeclaration
    // Need a specific order for these properties
    public string? FallbackReason { get; init; } = FallbackReason;
}