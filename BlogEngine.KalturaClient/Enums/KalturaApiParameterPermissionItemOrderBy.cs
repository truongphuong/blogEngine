namespace Kaltura
{
	public sealed class KalturaApiParameterPermissionItemOrderBy : KalturaStringEnum
	{
		public static readonly KalturaApiParameterPermissionItemOrderBy ID_ASC = new KalturaApiParameterPermissionItemOrderBy("+id");
		public static readonly KalturaApiParameterPermissionItemOrderBy ID_DESC = new KalturaApiParameterPermissionItemOrderBy("-id");
		public static readonly KalturaApiParameterPermissionItemOrderBy CREATED_AT_ASC = new KalturaApiParameterPermissionItemOrderBy("+createdAt");
		public static readonly KalturaApiParameterPermissionItemOrderBy CREATED_AT_DESC = new KalturaApiParameterPermissionItemOrderBy("-createdAt");
		public static readonly KalturaApiParameterPermissionItemOrderBy UPDATED_AT_ASC = new KalturaApiParameterPermissionItemOrderBy("+updatedAt");
		public static readonly KalturaApiParameterPermissionItemOrderBy UPDATED_AT_DESC = new KalturaApiParameterPermissionItemOrderBy("-updatedAt");

		private KalturaApiParameterPermissionItemOrderBy(string name) : base(name) { }
	}
}
