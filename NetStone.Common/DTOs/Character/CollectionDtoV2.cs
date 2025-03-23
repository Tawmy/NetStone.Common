namespace NetStone.Common.DTOs.Character;

public record CollectionDtoV2<T>(
    ICollection<T> List,
    bool Cached,
    DateTime? LastUpdated,
    int Total)
    : ICachingDtoV2
{
    public decimal Collected => List.Count;
    public decimal CollectedPercentage => Math.Round(decimal.Multiply(decimal.Divide(Collected, Total), 100), 2);
}