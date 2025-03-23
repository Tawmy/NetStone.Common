namespace NetStone.Common.DTOs.FreeCompany;

public record FreeCompanyMembersOuterDtoV3(
    IEnumerable<FreeCompanyMemberDtoV3> Members,
    bool Cached,
    DateTime? LastUpdated,
    bool FallbackUsed = false,
    string? FallbackReason = null) : ICachingDtoV3;