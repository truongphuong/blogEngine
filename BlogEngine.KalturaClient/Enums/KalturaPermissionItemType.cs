namespace Kaltura
{
	public sealed class KalturaPermissionItemType : KalturaStringEnum
	{
		public static readonly KalturaPermissionItemType API_ACTION_ITEM = new KalturaPermissionItemType("kApiActionPermissionItem");
		public static readonly KalturaPermissionItemType API_PARAMETER_ITEM = new KalturaPermissionItemType("kApiParameterPermissionItem");

		private KalturaPermissionItemType(string name) : base(name) { }
	}
}
