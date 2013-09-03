namespace Kaltura
{
	public sealed class KalturaThumbAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaThumbAssetOrderBy SIZE_ASC = new KalturaThumbAssetOrderBy("+size");
		public static readonly KalturaThumbAssetOrderBy SIZE_DESC = new KalturaThumbAssetOrderBy("-size");
		public static readonly KalturaThumbAssetOrderBy CREATED_AT_ASC = new KalturaThumbAssetOrderBy("+createdAt");
		public static readonly KalturaThumbAssetOrderBy CREATED_AT_DESC = new KalturaThumbAssetOrderBy("-createdAt");
		public static readonly KalturaThumbAssetOrderBy UPDATED_AT_ASC = new KalturaThumbAssetOrderBy("+updatedAt");
		public static readonly KalturaThumbAssetOrderBy UPDATED_AT_DESC = new KalturaThumbAssetOrderBy("-updatedAt");
		public static readonly KalturaThumbAssetOrderBy DELETED_AT_ASC = new KalturaThumbAssetOrderBy("+deletedAt");
		public static readonly KalturaThumbAssetOrderBy DELETED_AT_DESC = new KalturaThumbAssetOrderBy("-deletedAt");

		private KalturaThumbAssetOrderBy(string name) : base(name) { }
	}
}
