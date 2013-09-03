namespace Kaltura
{
	public sealed class KalturaUploadTokenOrderBy : KalturaStringEnum
	{
		public static readonly KalturaUploadTokenOrderBy CREATED_AT_ASC = new KalturaUploadTokenOrderBy("+createdAt");
		public static readonly KalturaUploadTokenOrderBy CREATED_AT_DESC = new KalturaUploadTokenOrderBy("-createdAt");

		private KalturaUploadTokenOrderBy(string name) : base(name) { }
	}
}
