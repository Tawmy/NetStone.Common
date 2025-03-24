namespace NetStone.Common.Enums;

public enum FallbackType
{
    /// <summary>
    ///     Never use fallback.
    /// </summary>
    None,

    /// <summary>
    ///     Use fallback for <see cref="HttpRequestException" />.
    /// </summary>
    Http,

    /// <summary>
    ///     Use fallback for any <see cref="Exception" />.
    /// </summary>
    Any
}