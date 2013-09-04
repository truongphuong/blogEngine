namespace Kaltura
{
	public sealed class KalturaDoubleClickDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDoubleClickDistributionProfileOrderBy CREATED_AT_ASC = new KalturaDoubleClickDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaDoubleClickDistributionProfileOrderBy CREATED_AT_DESC = new KalturaDoubleClickDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaDoubleClickDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaDoubleClickDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaDoubleClickDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaDoubleClickDistributionProfileOrderBy("-updatedAt");

		private KalturaDoubleClickDistributionProfileOrderBy(string name) : base(name) { }
	}
}
