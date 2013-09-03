namespace Kaltura
{
	public sealed class KalturaTVComDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaTVComDistributionProfileOrderBy CREATED_AT_ASC = new KalturaTVComDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaTVComDistributionProfileOrderBy CREATED_AT_DESC = new KalturaTVComDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaTVComDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaTVComDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaTVComDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaTVComDistributionProfileOrderBy("-updatedAt");

		private KalturaTVComDistributionProfileOrderBy(string name) : base(name) { }
	}
}
