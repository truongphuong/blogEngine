namespace Kaltura
{
	public sealed class KalturaAccessControlOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAccessControlOrderBy CREATED_AT_ASC = new KalturaAccessControlOrderBy("+createdAt");
		public static readonly KalturaAccessControlOrderBy CREATED_AT_DESC = new KalturaAccessControlOrderBy("-createdAt");

		private KalturaAccessControlOrderBy(string name) : base(name) { }
	}
}
