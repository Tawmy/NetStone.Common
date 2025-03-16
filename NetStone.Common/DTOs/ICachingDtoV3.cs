namespace NetStone.Common.DTOs;

public interface ICachingDtoV3 : ICachingDto
{
    bool FallbackUsed { get; init; }
    string? FallbackReason { get; init; }
}