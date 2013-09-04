namespace Kaltura
{
	public sealed class KalturaFreewheelGenericDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFreewheelGenericDistributionProfileOrderBy CREATED_AT_ASC = new KalturaFreewheelGenericDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaFreewheelGenericDistributionProfileOrderBy CREATED_AT_DESC = new KalturaFreewheelGenericDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaFreewheelGenericDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaFreewheelGenericDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaFreewheelGenericDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaFreewheelGenericDistributionProfileOrderBy("-updatedAt");

		private KalturaFreewheelGenericDistributionProfileOrderBy(string name) : base(name) { }
	}
}
