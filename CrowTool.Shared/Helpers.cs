using System.Text.Json;
using System.Text.Json.Serialization;

namespace CrowTool.Shared;

public static class Helpers
{
	public readonly static int TwitterExpiresInSeconds = 7200;

	public static JsonSerializerOptions JsonSeriOptions()
	{
		JsonSerializerOptions jsonSerializerOptions = new()
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.Never,
			WriteIndented = false,
			AllowTrailingCommas = false
		};
		return jsonSerializerOptions;
	}
}
