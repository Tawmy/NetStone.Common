namespace NetStone.Common.DTOs.Character;

public record CharacterSearchPageDto(
    bool HasResults,
    IEnumerable<CharacterSearchPageResultDto> Results,
    int CurrentPage,
    int NumPages);