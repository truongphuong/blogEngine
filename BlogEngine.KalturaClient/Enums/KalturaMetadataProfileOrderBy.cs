namespace Kaltura
{
	public sealed class KalturaMetadataProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMetadataProfileOrderBy CREATED_AT_ASC = new KalturaMetadataProfileOrderBy("+createdAt");
		public static readonly KalturaMetadataProfileOrderBy CREATED_AT_DESC = new KalturaMetadataProfileOrderBy("-createdAt");
		public static readonly KalturaMetadataProfileOrderBy UPDATED_AT_ASC = new KalturaMetadataProfileOrderBy("+updatedAt");
		public static readonly KalturaMetadataProfileOrderBy UPDATED_AT_DESC = new KalturaMetadataProfileOrderBy("-updatedAt");

		private KalturaMetadataProfileOrderBy(string name) : base(name) { }
	}
}
