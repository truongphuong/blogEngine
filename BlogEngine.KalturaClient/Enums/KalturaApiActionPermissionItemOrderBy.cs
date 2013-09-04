namespace Kaltura
{
	public sealed class KalturaApiActionPermissionItemOrderBy : KalturaStringEnum
	{
		public static readonly KalturaApiActionPermissionItemOrderBy ID_ASC = new KalturaApiActionPermissionItemOrderBy("+id");
		public static readonly KalturaApiActionPermissionItemOrderBy ID_DESC = new KalturaApiActionPermissionItemOrderBy("-id");
		public static readonly KalturaApiActionPermissionItemOrderBy CREATED_AT_ASC = new KalturaApiActionPermissionItemOrderBy("+createdAt");
		public static readonly KalturaApiActionPermissionItemOrderBy CREATED_AT_DESC = new KalturaApiActionPermissionItemOrderBy("-createdAt");
		public static readonly KalturaApiActionPermissionItemOrderBy UPDATED_AT_ASC = new KalturaApiActionPermissionItemOrderBy("+updatedAt");
		public static readonly KalturaApiActionPermissionItemOrderBy UPDATED_AT_DESC = new KalturaApiActionPermissionItemOrderBy("-updatedAt");

		private KalturaApiActionPermissionItemOrderBy(string name) : base(name) { }
	}
}
