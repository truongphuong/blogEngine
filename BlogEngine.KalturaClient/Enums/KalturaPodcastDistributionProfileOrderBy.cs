namespace Kaltura
{
	public sealed class KalturaPodcastDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPodcastDistributionProfileOrderBy CREATED_AT_ASC = new KalturaPodcastDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaPodcastDistributionProfileOrderBy CREATED_AT_DESC = new KalturaPodcastDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaPodcastDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaPodcastDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaPodcastDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaPodcastDistributionProfileOrderBy("-updatedAt");

		private KalturaPodcastDistributionProfileOrderBy(string name) : base(name) { }
	}
}
