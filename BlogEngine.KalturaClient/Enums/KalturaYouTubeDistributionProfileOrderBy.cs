namespace Kaltura
{
	public sealed class KalturaYouTubeDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaYouTubeDistributionProfileOrderBy CREATED_AT_ASC = new KalturaYouTubeDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaYouTubeDistributionProfileOrderBy CREATED_AT_DESC = new KalturaYouTubeDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaYouTubeDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaYouTubeDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaYouTubeDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaYouTubeDistributionProfileOrderBy("-updatedAt");

		private KalturaYouTubeDistributionProfileOrderBy(string name) : base(name) { }
	}
}
