namespace CrowTool.Shared;

public class TwitterLoginResponse
{
	// auth
	public string AccessToken { get; set; } = "";
	public string RefreshToken { get; set; } = "";
	public long ExpiresInTicks { get; set; } = 0;
	public string Scope { get; set; } = "";

	// user
	public long UserId { get; set; } = 0;
	public string Name { get; set; } = "";
	public string ScreenName { get; set; } = "";
	public string ProfileImageUrl { get; set; } = "";
	public string Description { get; set; } = "";
	public string WebSite { get; set; } = "";
	public string Location { get; set; } = "";
	public long PinnedTweetId { get; set; } = 0;
	public long CreatedAtTicks { get; set; } = 0;
	public long TweetCount { get; set; } = 0;
	public long FollowersCount { get; set; } = 0;
	public long FollowingCount { get; set; } = 0;
	public long FavoritesCount { get; set; } = 0;
	public bool PrivateAccount { get; set; } = false;
	public bool VerifiedAccount { get; set; } = false;
	//public object? WithHeld { get; set; }
}
