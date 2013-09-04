namespace Kaltura
{
	public sealed class KalturaComcastMrssDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaComcastMrssDistributionProfileOrderBy CREATED_AT_ASC = new KalturaComcastMrssDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaComcastMrssDistributionProfileOrderBy CREATED_AT_DESC = new KalturaComcastMrssDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaComcastMrssDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaComcastMrssDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaComcastMrssDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaComcastMrssDistributionProfileOrderBy("-updatedAt");

		private KalturaComcastMrssDistributionProfileOrderBy(string name) : base(name) { }
	}
}
