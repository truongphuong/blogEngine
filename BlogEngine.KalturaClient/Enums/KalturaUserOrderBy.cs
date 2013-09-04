namespace Kaltura
{
	public sealed class KalturaUserOrderBy : KalturaStringEnum
	{
		public static readonly KalturaUserOrderBy ID_ASC = new KalturaUserOrderBy("+id");
		public static readonly KalturaUserOrderBy ID_DESC = new KalturaUserOrderBy("-id");
		public static readonly KalturaUserOrderBy CREATED_AT_ASC = new KalturaUserOrderBy("+createdAt");
		public static readonly KalturaUserOrderBy CREATED_AT_DESC = new KalturaUserOrderBy("-createdAt");

		private KalturaUserOrderBy(string name) : base(name) { }
	}
}
