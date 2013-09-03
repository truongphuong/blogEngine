namespace Kaltura
{
	public sealed class KalturaDistributionProviderType : KalturaStringEnum
	{
		public static readonly KalturaDistributionProviderType GENERIC = new KalturaDistributionProviderType("1");
		public static readonly KalturaDistributionProviderType SYNDICATION = new KalturaDistributionProviderType("2");
		public static readonly KalturaDistributionProviderType YOUTUBE = new KalturaDistributionProviderType("youTubeDistribution.YOUTUBE");
		public static readonly KalturaDistributionProviderType YOUTUBE_API = new KalturaDistributionProviderType("youtubeApiDistribution.YOUTUBE_API");
		public static readonly KalturaDistributionProviderType DAILYMOTION = new KalturaDistributionProviderType("dailymotionDistribution.DAILYMOTION");
		public static readonly KalturaDistributionProviderType PODCAST = new KalturaDistributionProviderType("podcastDistribution.PODCAST");
		public static readonly KalturaDistributionProviderType TVCOM = new KalturaDistributionProviderType("tvComDistribution.TVCOM");
		public static readonly KalturaDistributionProviderType FREEWHEEL = new KalturaDistributionProviderType("freewheelDistribution.FREEWHEEL");
		public static readonly KalturaDistributionProviderType FREEWHEEL_GENERIC = new KalturaDistributionProviderType("freewheelGenericDistribution.FREEWHEEL_GENERIC");
		public static readonly KalturaDistributionProviderType HULU = new KalturaDistributionProviderType("huluDistribution.HULU");
		public static readonly KalturaDistributionProviderType DOUBLECLICK = new KalturaDistributionProviderType("doubleClickDistribution.DOUBLECLICK");

		private KalturaDistributionProviderType(string name) : base(name) { }
	}
}
