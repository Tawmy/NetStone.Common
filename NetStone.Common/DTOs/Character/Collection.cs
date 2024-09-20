namespace NetStone.Common.DTOs.Character;

public readonly record struct Collection(int Total, int Collected)
{
    public decimal CollectedPercentage => Math.Round(decimal.Multiply(decimal.Divide(Collected, Total), 100), 2);
}