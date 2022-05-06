using System.Text.Json;
using System.Text.Json.Serialization;

namespace CrowTool.Shared;

public static class Helpers
{
	/// <summary>
	///
	/// </summary>
	public readonly static int TwitterExpiresInSeconds = 7200;

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
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
