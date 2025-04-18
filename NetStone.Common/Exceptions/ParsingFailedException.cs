namespace NetStone.Common.Exceptions;

/// <summary>
///     Thrown if parsing failed. This can happen when a profile is private of the Lodestone is down.
/// </summary>
public class ParsingFailedException(string lodestoneId) : Exception(lodestoneId);