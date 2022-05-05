using CrowTool.Shared;

namespace CrowTool.StaticBlazorWasmClient.Services;

public class StateContainerService
{
	private TwitterLoginResponse P_UserInfo { get; set; } = new();

	public TwitterLoginResponse UserInfo
	{
		get => P_UserInfo;
		set
		{
			P_UserInfo = value;
			NotifyStateChanged();
		}
	}

	public event Action? OnChange;

	private void NotifyStateChanged() => OnChange?.Invoke();
}
