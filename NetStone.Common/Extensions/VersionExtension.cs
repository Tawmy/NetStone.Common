namespace NetStone.Common.Extensions;

public static class VersionExtension
{
    public static string ToVersionString(this Version version)
    {
        return $"{version.Major}.{version.Minor}.{version.Build}";
    }
}