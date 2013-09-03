namespace Kaltura
{
	public sealed class KalturaControlPanelCommandOrderBy : KalturaStringEnum
	{
		public static readonly KalturaControlPanelCommandOrderBy CREATED_AT_ASC = new KalturaControlPanelCommandOrderBy("+createdAt");
		public static readonly KalturaControlPanelCommandOrderBy CREATED_AT_DESC = new KalturaControlPanelCommandOrderBy("-createdAt");
		public static readonly KalturaControlPanelCommandOrderBy UPDATED_AT_ASC = new KalturaControlPanelCommandOrderBy("+updatedAt");
		public static readonly KalturaControlPanelCommandOrderBy UPDATED_AT_DESC = new KalturaControlPanelCommandOrderBy("-updatedAt");

		private KalturaControlPanelCommandOrderBy(string name) : base(name) { }
	}
}
