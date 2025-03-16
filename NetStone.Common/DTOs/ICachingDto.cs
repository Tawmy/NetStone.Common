namespace NetStone.Common.DTOs;

public interface ICachingDto
{
    bool Cached { get; init; }
    DateTime? LastUpdated { get; init; }
}