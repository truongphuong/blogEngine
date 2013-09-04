namespace Kaltura
{
	public sealed class KalturaCaptionAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCaptionAssetOrderBy SIZE_ASC = new KalturaCaptionAssetOrderBy("+size");
		public static readonly KalturaCaptionAssetOrderBy SIZE_DESC = new KalturaCaptionAssetOrderBy("-size");
		public static readonly KalturaCaptionAssetOrderBy CREATED_AT_ASC = new KalturaCaptionAssetOrderBy("+createdAt");
		public static readonly KalturaCaptionAssetOrderBy CREATED_AT_DESC = new KalturaCaptionAssetOrderBy("-createdAt");
		public static readonly KalturaCaptionAssetOrderBy UPDATED_AT_ASC = new KalturaCaptionAssetOrderBy("+updatedAt");
		public static readonly KalturaCaptionAssetOrderBy UPDATED_AT_DESC = new KalturaCaptionAssetOrderBy("-updatedAt");
		public static readonly KalturaCaptionAssetOrderBy DELETED_AT_ASC = new KalturaCaptionAssetOrderBy("+deletedAt");
		public static readonly KalturaCaptionAssetOrderBy DELETED_AT_DESC = new KalturaCaptionAssetOrderBy("-deletedAt");

		private KalturaCaptionAssetOrderBy(string name) : base(name) { }
	}
}
