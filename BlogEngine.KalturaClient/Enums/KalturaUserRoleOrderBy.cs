namespace Kaltura
{
	public sealed class KalturaUserRoleOrderBy : KalturaStringEnum
	{
		public static readonly KalturaUserRoleOrderBy ID_ASC = new KalturaUserRoleOrderBy("+id");
		public static readonly KalturaUserRoleOrderBy ID_DESC = new KalturaUserRoleOrderBy("-id");
		public static readonly KalturaUserRoleOrderBy NAME_ASC = new KalturaUserRoleOrderBy("+name");
		public static readonly KalturaUserRoleOrderBy NAME_DESC = new KalturaUserRoleOrderBy("-name");
		public static readonly KalturaUserRoleOrderBy CREATED_AT_ASC = new KalturaUserRoleOrderBy("+createdAt");
		public static readonly KalturaUserRoleOrderBy CREATED_AT_DESC = new KalturaUserRoleOrderBy("-createdAt");
		public static readonly KalturaUserRoleOrderBy UPDATED_AT_ASC = new KalturaUserRoleOrderBy("+updatedAt");
		public static readonly KalturaUserRoleOrderBy UPDATED_AT_DESC = new KalturaUserRoleOrderBy("-updatedAt");

		private KalturaUserRoleOrderBy(string name) : base(name) { }
	}
}
