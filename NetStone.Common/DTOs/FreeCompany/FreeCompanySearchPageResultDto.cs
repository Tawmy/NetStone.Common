using NetStone.Common.Enums;

namespace NetStone.Common.DTOs.FreeCompany;

public record FreeCompanySearchPageResultDto
{
    public required string Name { get; init; }
    public required string Id { get; init; }
    public required string Server { get; init; }
    public required string Datacenter { get; init; }
    public required FreeCompanyCrestDto CrestLayers { get; init; }
    public required DateTime Formed { get; init; }
    public required ActiveTimes Active { get; init; }
    public required int ActiveMembers { get; init; }
    public required bool RecruitmentOpen { get; init; }
    public required string GrandCompany { get; init; }
    public required Housing EstateBuild { get; init; }
}