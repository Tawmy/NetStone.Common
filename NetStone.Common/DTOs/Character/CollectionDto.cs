namespace NetStone.Common.DTOs.Character;

public record CollectionDto<T>(
    ICollection<T> List,
    bool Cached,
    DateTime? LastUpdated,
    int Total)
    : ICachingDto
{
    public decimal Collected => List.Count;
    public decimal CollectedPercentage => Math.Round(decimal.Multiply(decimal.Divide(Collected, Total), 100), 2);
}