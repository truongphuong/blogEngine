namespace Kaltura
{
	public sealed class KalturaYoutubeApiDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaYoutubeApiDistributionProfileOrderBy CREATED_AT_ASC = new KalturaYoutubeApiDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaYoutubeApiDistributionProfileOrderBy CREATED_AT_DESC = new KalturaYoutubeApiDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaYoutubeApiDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaYoutubeApiDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaYoutubeApiDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaYoutubeApiDistributionProfileOrderBy("-updatedAt");

		private KalturaYoutubeApiDistributionProfileOrderBy(string name) : base(name) { }
	}
}
