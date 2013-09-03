namespace Kaltura
{
	public sealed class KalturaUiConfOrderBy : KalturaStringEnum
	{
		public static readonly KalturaUiConfOrderBy CREATED_AT_ASC = new KalturaUiConfOrderBy("+createdAt");
		public static readonly KalturaUiConfOrderBy CREATED_AT_DESC = new KalturaUiConfOrderBy("-createdAt");
		public static readonly KalturaUiConfOrderBy UPDATED_AT_ASC = new KalturaUiConfOrderBy("+updatedAt");
		public static readonly KalturaUiConfOrderBy UPDATED_AT_DESC = new KalturaUiConfOrderBy("-updatedAt");

		private KalturaUiConfOrderBy(string name) : base(name) { }
	}
}
