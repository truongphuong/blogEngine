namespace Kaltura
{
	public sealed class KalturaAvnDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAvnDistributionProfileOrderBy CREATED_AT_ASC = new KalturaAvnDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaAvnDistributionProfileOrderBy CREATED_AT_DESC = new KalturaAvnDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaAvnDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaAvnDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaAvnDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaAvnDistributionProfileOrderBy("-updatedAt");

		private KalturaAvnDistributionProfileOrderBy(string name) : base(name) { }
	}
}
