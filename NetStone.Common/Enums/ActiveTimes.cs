using System.Text.Json.Serialization;

namespace NetStone.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ActiveTimes
{
    All,
    WeekdaysOnly,
    WeekendsOnly,
    Always
}