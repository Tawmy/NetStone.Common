namespace NetStone.Common.DTOs;

public interface ICachingDtoV2
{
    bool Cached { get; init; }
    DateTime? LastUpdated { get; init; }
}