namespace Kaltura
{
	public sealed class KalturaVirusScanProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaVirusScanProfileOrderBy CREATED_AT_ASC = new KalturaVirusScanProfileOrderBy("+createdAt");
		public static readonly KalturaVirusScanProfileOrderBy CREATED_AT_DESC = new KalturaVirusScanProfileOrderBy("-createdAt");
		public static readonly KalturaVirusScanProfileOrderBy UPDATED_AT_ASC = new KalturaVirusScanProfileOrderBy("+updatedAt");
		public static readonly KalturaVirusScanProfileOrderBy UPDATED_AT_DESC = new KalturaVirusScanProfileOrderBy("-updatedAt");

		private KalturaVirusScanProfileOrderBy(string name) : base(name) { }
	}
}
