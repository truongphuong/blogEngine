namespace Kaltura
{
	public sealed class KalturaWidgetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaWidgetOrderBy CREATED_AT_ASC = new KalturaWidgetOrderBy("+createdAt");
		public static readonly KalturaWidgetOrderBy CREATED_AT_DESC = new KalturaWidgetOrderBy("-createdAt");

		private KalturaWidgetOrderBy(string name) : base(name) { }
	}
}
