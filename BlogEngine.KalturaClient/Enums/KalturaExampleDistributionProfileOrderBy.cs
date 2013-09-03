namespace Kaltura
{
	public sealed class KalturaExampleDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaExampleDistributionProfileOrderBy CREATED_AT_ASC = new KalturaExampleDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaExampleDistributionProfileOrderBy CREATED_AT_DESC = new KalturaExampleDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaExampleDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaExampleDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaExampleDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaExampleDistributionProfileOrderBy("-updatedAt");

		private KalturaExampleDistributionProfileOrderBy(string name) : base(name) { }
	}
}
