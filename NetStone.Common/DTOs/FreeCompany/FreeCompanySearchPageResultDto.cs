using NetStone.Common.Enums;

namespace NetStone.Common.DTOs.FreeCompany;

public record FreeCompanySearchPageResultDto(
    string Name,
    string Id,
    string Server,
    string Datacenter,
    FreeCompanyCrestDto CrestLayers,
    DateTime Formed,
    ActiveTimes Active,
    short ActiveMembers,
    bool RecruitmentOpen,
    string GrandCompany,
    Housing EstateBuild);