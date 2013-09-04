namespace Kaltura
{
	public sealed class KalturaGenericDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericDistributionProfileOrderBy CREATED_AT_ASC = new KalturaGenericDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaGenericDistributionProfileOrderBy CREATED_AT_DESC = new KalturaGenericDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaGenericDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaGenericDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaGenericDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaGenericDistributionProfileOrderBy("-updatedAt");

		private KalturaGenericDistributionProfileOrderBy(string name) : base(name) { }
	}
}
