namespace NetStone.Common.Enums;

[Flags]
public enum FallbackTypeV4
{
    /// <summary>
    ///     Never use fallback.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Use fallback for <see cref="HttpRequestException" />.
    /// </summary>
    Http = 1 << 0,

    /// <summary>
    ///     Use fallback when Lodestone is unavailable, either for maintenance or if profile sub-pages are private.
    /// </summary>
    LodestoneUnavailable = 1 << 1,

    /// <summary>
    ///     Use fallback when profile is private. This only works for a user's full profile, not sub-pages like minions!
    /// </summary>
    ProfilePrivate = 1 << 2,

    /// <summary>
    ///     Use fallback for any <see cref="Exception" />.
    /// </summary>
    Any = 1 << 3
}

public enum FallbackTypeV3
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