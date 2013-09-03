namespace Kaltura
{
	public sealed class KalturaConfigurableDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaConfigurableDistributionProfileOrderBy CREATED_AT_ASC = new KalturaConfigurableDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaConfigurableDistributionProfileOrderBy CREATED_AT_DESC = new KalturaConfigurableDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaConfigurableDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaConfigurableDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaConfigurableDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaConfigurableDistributionProfileOrderBy("-updatedAt");

		private KalturaConfigurableDistributionProfileOrderBy(string name) : base(name) { }
	}
}
