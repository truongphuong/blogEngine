namespace Kaltura
{
	public sealed class KalturaPermissionOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPermissionOrderBy ID_ASC = new KalturaPermissionOrderBy("+id");
		public static readonly KalturaPermissionOrderBy ID_DESC = new KalturaPermissionOrderBy("-id");
		public static readonly KalturaPermissionOrderBy NAME_ASC = new KalturaPermissionOrderBy("+name");
		public static readonly KalturaPermissionOrderBy NAME_DESC = new KalturaPermissionOrderBy("-name");
		public static readonly KalturaPermissionOrderBy CREATED_AT_ASC = new KalturaPermissionOrderBy("+createdAt");
		public static readonly KalturaPermissionOrderBy CREATED_AT_DESC = new KalturaPermissionOrderBy("-createdAt");
		public static readonly KalturaPermissionOrderBy UPDATED_AT_ASC = new KalturaPermissionOrderBy("+updatedAt");
		public static readonly KalturaPermissionOrderBy UPDATED_AT_DESC = new KalturaPermissionOrderBy("-updatedAt");

		private KalturaPermissionOrderBy(string name) : base(name) { }
	}
}
