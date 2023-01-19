using System.Text.Json.Serialization;

namespace DAL.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssignmentStatus
{
    Todo,
    InProgress,
    Done
}
