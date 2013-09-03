namespace Kaltura
{
	public sealed class KalturaPermissionItemOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPermissionItemOrderBy ID_ASC = new KalturaPermissionItemOrderBy("+id");
		public static readonly KalturaPermissionItemOrderBy ID_DESC = new KalturaPermissionItemOrderBy("-id");
		public static readonly KalturaPermissionItemOrderBy CREATED_AT_ASC = new KalturaPermissionItemOrderBy("+createdAt");
		public static readonly KalturaPermissionItemOrderBy CREATED_AT_DESC = new KalturaPermissionItemOrderBy("-createdAt");
		public static readonly KalturaPermissionItemOrderBy UPDATED_AT_ASC = new KalturaPermissionItemOrderBy("+updatedAt");
		public static readonly KalturaPermissionItemOrderBy UPDATED_AT_DESC = new KalturaPermissionItemOrderBy("-updatedAt");

		private KalturaPermissionItemOrderBy(string name) : base(name) { }
	}
}
