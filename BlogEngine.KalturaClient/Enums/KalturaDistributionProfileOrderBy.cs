namespace Kaltura
{
	public sealed class KalturaDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDistributionProfileOrderBy CREATED_AT_ASC = new KalturaDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaDistributionProfileOrderBy CREATED_AT_DESC = new KalturaDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaDistributionProfileOrderBy("-updatedAt");

		private KalturaDistributionProfileOrderBy(string name) : base(name) { }
	}
}
