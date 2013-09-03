namespace Kaltura
{
	public sealed class KalturaIdeticDistributionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaIdeticDistributionProfileOrderBy CREATED_AT_ASC = new KalturaIdeticDistributionProfileOrderBy("+createdAt");
		public static readonly KalturaIdeticDistributionProfileOrderBy CREATED_AT_DESC = new KalturaIdeticDistributionProfileOrderBy("-createdAt");
		public static readonly KalturaIdeticDistributionProfileOrderBy UPDATED_AT_ASC = new KalturaIdeticDistributionProfileOrderBy("+updatedAt");
		public static readonly KalturaIdeticDistributionProfileOrderBy UPDATED_AT_DESC = new KalturaIdeticDistributionProfileOrderBy("-updatedAt");

		private KalturaIdeticDistributionProfileOrderBy(string name) : base(name) { }
	}
}
