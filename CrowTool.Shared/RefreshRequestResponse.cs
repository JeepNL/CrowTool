using System.Text.Json.Serialization;

namespace CrowTool.Shared;

// Convert Json to C# Classes Online https://json2csharp.com/
// RefreshRequestResponse myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class RefreshRequestResponse
{
	[JsonPropertyName("token_type")]
	public string TokenType { get; init; } = "";

	[JsonPropertyName("expires_in")]
	public int ExpiresIn { get; init; } = 0;

	[JsonPropertyName("access_token")]
	public string AccessToken { get; init; } = "";

	[JsonPropertyName("scope")]
	public string Scope { get; init; } = "";

	[JsonPropertyName("refresh_token")]
	public string RefreshToken { get; init; } = "";
}

