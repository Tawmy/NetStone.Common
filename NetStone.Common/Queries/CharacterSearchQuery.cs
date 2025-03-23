using NetStone.Common.Enums;

namespace NetStone.Common.Queries;

public record CharacterSearchQuery(
    string CharacterName,
    string? World = null,
    string? DataCenter = null,
    Role? Role = null,
    ClassJob? ClassJob = null,
    Race? Race = null,
    Tribe? Tribe = null,
    GrandCompany? GrandCompany = null,
    Language? Language = null,
    SortKindCharacter? SortKind = null);