namespace Kaltura
{
	public sealed class KalturaGenericDistributionProviderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericDistributionProviderOrderBy CREATED_AT_ASC = new KalturaGenericDistributionProviderOrderBy("+createdAt");
		public static readonly KalturaGenericDistributionProviderOrderBy CREATED_AT_DESC = new KalturaGenericDistributionProviderOrderBy("-createdAt");
		public static readonly KalturaGenericDistributionProviderOrderBy UPDATED_AT_ASC = new KalturaGenericDistributionProviderOrderBy("+updatedAt");
		public static readonly KalturaGenericDistributionProviderOrderBy UPDATED_AT_DESC = new KalturaGenericDistributionProviderOrderBy("-updatedAt");

		private KalturaGenericDistributionProviderOrderBy(string name) : base(name) { }
	}
}
