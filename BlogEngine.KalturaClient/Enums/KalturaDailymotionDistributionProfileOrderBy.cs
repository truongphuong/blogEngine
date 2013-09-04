namespace Kaltura
{
	public sealed class KalturaDailymotionDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDailymotionDistributionProfileOrderBy CREATED_AT_ASC = new KalturaDailymotionDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaDailymotionDistributionProfileOrderBy CREATED_AT_DESC = new KalturaDailymotionDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaDailymotionDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaDailymotionDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaDailymotionDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaDailymotionDistributionProfileOrderBy("-updatedAt");

		private KalturaDailymotionDistributionProfileOrderBy(string name) : base(name) { }
	}
}
