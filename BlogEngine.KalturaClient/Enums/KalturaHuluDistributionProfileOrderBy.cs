namespace Kaltura
{
	public sealed class KalturaHuluDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaHuluDistributionProfileOrderBy CREATED_AT_ASC = new KalturaHuluDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaHuluDistributionProfileOrderBy CREATED_AT_DESC = new KalturaHuluDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaHuluDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaHuluDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaHuluDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaHuluDistributionProfileOrderBy("-updatedAt");

		private KalturaHuluDistributionProfileOrderBy(string name) : base(name) { }
	}
}
