namespace NetStone.Common.DTOs.Character;

public record CollectionDto<T>(
    ICollection<T> List,
    bool Cached,
    DateTime? LastUpdated,
    int Total)
{
    private int Total { get; } = Total;
    public Collection Collection => new(Total, List.Count);
}