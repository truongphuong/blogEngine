namespace Kaltura
{
	public sealed class KalturaGenericDistributionProviderActionOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericDistributionProviderActionOrderBy CREATED_AT_ASC = new KalturaGenericDistributionProviderActionOrderBy("+createdAt");
		public static readonly KalturaGenericDistributionProviderActionOrderBy CREATED_AT_DESC = new KalturaGenericDistributionProviderActionOrderBy("-createdAt");
		public static readonly KalturaGenericDistributionProviderActionOrderBy UPDATED_AT_ASC = new KalturaGenericDistributionProviderActionOrderBy("+updatedAt");
		public static readonly KalturaGenericDistributionProviderActionOrderBy UPDATED_AT_DESC = new KalturaGenericDistributionProviderActionOrderBy("-updatedAt");

		private KalturaGenericDistributionProviderActionOrderBy(string name) : base(name) { }
	}
}
