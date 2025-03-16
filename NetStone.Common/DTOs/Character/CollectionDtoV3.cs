namespace NetStone.Common.DTOs.Character;

public record CollectionDtoV3<T>(
    ICollection<T> List,
    bool Cached,
    DateTime? LastUpdated,
    int Total,
    bool FallbackUsed = false,
    string? FallbackReason = null) : ICachingDtoV3;