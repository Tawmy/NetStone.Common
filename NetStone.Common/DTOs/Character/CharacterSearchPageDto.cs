namespace NetStone.Common.DTOs.Character;

public record CharacterSearchPageDto(
    bool HasResults,
    IEnumerable<CharacterSearchPageResultDto> Results,
    short CurrentPage,
    short NumPages);