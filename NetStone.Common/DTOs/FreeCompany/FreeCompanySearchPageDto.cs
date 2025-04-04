namespace NetStone.Common.DTOs.FreeCompany;

public record FreeCompanySearchPageDto(
    bool HasResults,
    IEnumerable<FreeCompanySearchPageResultDto> Results,
    int CurrentPage,
    int NumPages);