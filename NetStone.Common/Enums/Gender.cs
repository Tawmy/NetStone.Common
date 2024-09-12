using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Gender
{
    Male,
    Female
}