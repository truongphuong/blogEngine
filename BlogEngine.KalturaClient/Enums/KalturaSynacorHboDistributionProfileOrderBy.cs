namespace Kaltura
{
	public sealed class KalturaSynacorHboDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaSynacorHboDistributionProfileOrderBy CREATED_AT_ASC = new KalturaSynacorHboDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaSynacorHboDistributionProfileOrderBy CREATED_AT_DESC = new KalturaSynacorHboDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaSynacorHboDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaSynacorHboDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaSynacorHboDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaSynacorHboDistributionProfileOrderBy("-updatedAt");

		private KalturaSynacorHboDistributionProfileOrderBy(string name) : base(name) { }
	}
}
