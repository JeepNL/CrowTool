namespace CrowTool.Shared;

public class TwitterLoginRequest
{
	public string Code { get; set; } = "";
	public string State { get; set; } = "";
	public string Challenge { get; set; } = "";
}
