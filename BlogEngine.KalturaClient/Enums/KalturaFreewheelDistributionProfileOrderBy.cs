namespace Kaltura
{
	public sealed class KalturaFreewheelDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFreewheelDistributionProfileOrderBy CREATED_AT_ASC = new KalturaFreewheelDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaFreewheelDistributionProfileOrderBy CREATED_AT_DESC = new KalturaFreewheelDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaFreewheelDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaFreewheelDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaFreewheelDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaFreewheelDistributionProfileOrderBy("-updatedAt");

		private KalturaFreewheelDistributionProfileOrderBy(string name) : base(name) { }
	}
}
