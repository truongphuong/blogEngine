namespace Kaltura
{
	public sealed class KalturaAttachmentAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAttachmentAssetOrderBy SIZE_ASC = new KalturaAttachmentAssetOrderBy("+size");
		public static readonly KalturaAttachmentAssetOrderBy SIZE_DESC = new KalturaAttachmentAssetOrderBy("-size");
		public static readonly KalturaAttachmentAssetOrderBy CREATED_AT_ASC = new KalturaAttachmentAssetOrderBy("+createdAt");
		public static readonly KalturaAttachmentAssetOrderBy CREATED_AT_DESC = new KalturaAttachmentAssetOrderBy("-createdAt");
		public static readonly KalturaAttachmentAssetOrderBy UPDATED_AT_ASC = new KalturaAttachmentAssetOrderBy("+updatedAt");
		public static readonly KalturaAttachmentAssetOrderBy UPDATED_AT_DESC = new KalturaAttachmentAssetOrderBy("-updatedAt");
		public static readonly KalturaAttachmentAssetOrderBy DELETED_AT_ASC = new KalturaAttachmentAssetOrderBy("+deletedAt");
		public static readonly KalturaAttachmentAssetOrderBy DELETED_AT_DESC = new KalturaAttachmentAssetOrderBy("-deletedAt");

		private KalturaAttachmentAssetOrderBy(string name) : base(name) { }
	}
}
