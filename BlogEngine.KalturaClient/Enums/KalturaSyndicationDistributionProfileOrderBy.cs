namespace Kaltura
{
	public sealed class KalturaSyndicationDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaSyndicationDistributionProfileOrderBy CREATED_AT_ASC = new KalturaSyndicationDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaSyndicationDistributionProfileOrderBy CREATED_AT_DESC = new KalturaSyndicationDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaSyndicationDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaSyndicationDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaSyndicationDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaSyndicationDistributionProfileOrderBy("-updatedAt");

		private KalturaSyndicationDistributionProfileOrderBy(string name) : base(name) { }
	}
}
