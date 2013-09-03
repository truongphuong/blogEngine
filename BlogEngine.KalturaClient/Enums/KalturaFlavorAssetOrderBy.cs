namespace Kaltura
{
	public sealed class KalturaFlavorAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFlavorAssetOrderBy SIZE_ASC = new KalturaFlavorAssetOrderBy("+size");
		public static readonly KalturaFlavorAssetOrderBy SIZE_DESC = new KalturaFlavorAssetOrderBy("-size");
		public static readonly KalturaFlavorAssetOrderBy CREATED_AT_ASC = new KalturaFlavorAssetOrderBy("+createdAt");
		public static readonly KalturaFlavorAssetOrderBy CREATED_AT_DESC = new KalturaFlavorAssetOrderBy("-createdAt");
		public static readonly KalturaFlavorAssetOrderBy UPDATED_AT_ASC = new KalturaFlavorAssetOrderBy("+updatedAt");
		public static readonly KalturaFlavorAssetOrderBy UPDATED_AT_DESC = new KalturaFlavorAssetOrderBy("-updatedAt");
		public static readonly KalturaFlavorAssetOrderBy DELETED_AT_ASC = new KalturaFlavorAssetOrderBy("+deletedAt");
		public static readonly KalturaFlavorAssetOrderBy DELETED_AT_DESC = new KalturaFlavorAssetOrderBy("-deletedAt");

		private KalturaFlavorAssetOrderBy(string name) : base(name) { }
	}
}
