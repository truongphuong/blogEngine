namespace Kaltura
{
	public sealed class KalturaApiParameterPermissionItemAction : KalturaStringEnum
	{
		public static readonly KalturaApiParameterPermissionItemAction READ = new KalturaApiParameterPermissionItemAction("read");
		public static readonly KalturaApiParameterPermissionItemAction UPDATE = new KalturaApiParameterPermissionItemAction("update");
		public static readonly KalturaApiParameterPermissionItemAction INSERT = new KalturaApiParameterPermissionItemAction("insert");
		public static readonly KalturaApiParameterPermissionItemAction USEAGE = new KalturaApiParameterPermissionItemAction("all");

		private KalturaApiParameterPermissionItemAction(string name) : base(name) { }
	}
}
