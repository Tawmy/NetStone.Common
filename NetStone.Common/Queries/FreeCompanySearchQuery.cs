using NetStone.Common.Enums;

namespace NetStone.Common.Queries;

public record FreeCompanySearchQuery(
    string Name,
    string? World = null,
    string? DataCenter = null,
    bool IsCommunityFinderRecruiting = false,
    ActiveTimes ActiveTimes = ActiveTimes.All,
    ActiveMembers ActiveMembers = ActiveMembers.All,
    Recruitment Recruitment = Recruitment.All,
    Housing Housing = Housing.All,
    FreeCompanyFocus Focus = FreeCompanyFocus.NotSpecified,
    Seeking Seeking = Seeking.NotSpecified,
    GrandCompany GrandCompany = GrandCompany.NoAffiliation,
    SortKind SortKind = SortKind.NameAtoZ);