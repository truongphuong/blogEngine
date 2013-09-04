namespace Kaltura
{
	public sealed class KalturaAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAssetOrderBy SIZE_ASC = new KalturaAssetOrderBy("+size");
		public static readonly KalturaAssetOrderBy SIZE_DESC = new KalturaAssetOrderBy("-size");
		public static readonly KalturaAssetOrderBy CREATED_AT_ASC = new KalturaAssetOrderBy("+createdAt");
		public static readonly KalturaAssetOrderBy CREATED_AT_DESC = new KalturaAssetOrderBy("-createdAt");
		public static readonly KalturaAssetOrderBy UPDATED_AT_ASC = new KalturaAssetOrderBy("+updatedAt");
		public static readonly KalturaAssetOrderBy UPDATED_AT_DESC = new KalturaAssetOrderBy("-updatedAt");
		public static readonly KalturaAssetOrderBy DELETED_AT_ASC = new KalturaAssetOrderBy("+deletedAt");
		public static readonly KalturaAssetOrderBy DELETED_AT_DESC = new KalturaAssetOrderBy("-deletedAt");

		private KalturaAssetOrderBy(string name) : base(name) { }
	}
}
