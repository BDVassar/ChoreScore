using System.Text.Json.Serialization;

namespace ChoreScore.Enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Chorepriority
{
  low,
  medium,
  high
}
