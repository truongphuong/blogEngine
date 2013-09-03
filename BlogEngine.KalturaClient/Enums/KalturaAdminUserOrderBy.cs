namespace Kaltura
{
	public sealed class KalturaAdminUserOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAdminUserOrderBy ID_ASC = new KalturaAdminUserOrderBy("+id");
		public static readonly KalturaAdminUserOrderBy ID_DESC = new KalturaAdminUserOrderBy("-id");
		public static readonly KalturaAdminUserOrderBy CREATED_AT_ASC = new KalturaAdminUserOrderBy("+createdAt");
		public static readonly KalturaAdminUserOrderBy CREATED_AT_DESC = new KalturaAdminUserOrderBy("-createdAt");

		private KalturaAdminUserOrderBy(string name) : base(name) { }
	}
}
