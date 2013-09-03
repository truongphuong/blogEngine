namespace Kaltura
{
	public sealed class KalturaUiConfAdminOrderBy : KalturaStringEnum
	{
		public static readonly KalturaUiConfAdminOrderBy CREATED_AT_ASC = new KalturaUiConfAdminOrderBy("+createdAt");
		public static readonly KalturaUiConfAdminOrderBy CREATED_AT_DESC = new KalturaUiConfAdminOrderBy("-createdAt");
		public static readonly KalturaUiConfAdminOrderBy UPDATED_AT_ASC = new KalturaUiConfAdminOrderBy("+updatedAt");
		public static readonly KalturaUiConfAdminOrderBy UPDATED_AT_DESC = new KalturaUiConfAdminOrderBy("-updatedAt");

		private KalturaUiConfAdminOrderBy(string name) : base(name) { }
	}
}
