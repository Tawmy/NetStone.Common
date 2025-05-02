namespace NetStone.Common.DTOs;

public interface ICachingDtoV3
{
    bool Cached { get; init; }
    DateTime? LastUpdated { get; init; }
    bool FallbackUsed { get; init; }
    string? FallbackReason { get; init; }
}