namespace Kaltura
{
	public sealed class KalturaShortLinkOrderBy : KalturaStringEnum
	{
		public static readonly KalturaShortLinkOrderBy CREATED_AT_ASC = new KalturaShortLinkOrderBy("+createdAt");
		public static readonly KalturaShortLinkOrderBy CREATED_AT_DESC = new KalturaShortLinkOrderBy("-createdAt");
		public static readonly KalturaShortLinkOrderBy UPDATED_AT_ASC = new KalturaShortLinkOrderBy("+updatedAt");
		public static readonly KalturaShortLinkOrderBy UPDATED_AT_DESC = new KalturaShortLinkOrderBy("-updatedAt");
		public static readonly KalturaShortLinkOrderBy EXPIRES_AT_ASC = new KalturaShortLinkOrderBy("+expiresAt");
		public static readonly KalturaShortLinkOrderBy EXPIRES_AT_DESC = new KalturaShortLinkOrderBy("-expiresAt");

		private KalturaShortLinkOrderBy(string name) : base(name) { }
	}
}
