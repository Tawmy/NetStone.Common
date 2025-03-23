namespace NetStone.Common.DTOs.FreeCompany;

public record FreeCompanyMembersOuterDtoV2(
    IEnumerable<FreeCompanyMemberDtoV2> Members,
    bool Cached,
    DateTime? LastUpdated) : ICachingDtoV2;