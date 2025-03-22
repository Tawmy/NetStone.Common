namespace NetStone.Common.DTOs;

public interface ICachingDtoV3 : ICachingDtoV2
{
    bool FallbackUsed { get; init; }
    string? FallbackReason { get; init; }
}