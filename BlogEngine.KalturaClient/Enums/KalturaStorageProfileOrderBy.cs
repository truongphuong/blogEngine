namespace Kaltura
{
	public sealed class KalturaStorageProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaStorageProfileOrderBy CREATED_AT_ASC = new KalturaStorageProfileOrderBy("+createdAt");
		public static readonly KalturaStorageProfileOrderBy CREATED_AT_DESC = new KalturaStorageProfileOrderBy("-createdAt");
		public static readonly KalturaStorageProfileOrderBy UPDATED_AT_ASC = new KalturaStorageProfileOrderBy("+updatedAt");
		public static readonly KalturaStorageProfileOrderBy UPDATED_AT_DESC = new KalturaStorageProfileOrderBy("-updatedAt");

		private KalturaStorageProfileOrderBy(string name) : base(name) { }
	}
}
