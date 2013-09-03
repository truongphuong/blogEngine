namespace Kaltura
{
	public sealed class KalturaMetadataOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMetadataOrderBy METADATA_PROFILE_VERSION_ASC = new KalturaMetadataOrderBy("+metadataProfileVersion");
		public static readonly KalturaMetadataOrderBy METADATA_PROFILE_VERSION_DESC = new KalturaMetadataOrderBy("-metadataProfileVersion");
		public static readonly KalturaMetadataOrderBy VERSION_ASC = new KalturaMetadataOrderBy("+version");
		public static readonly KalturaMetadataOrderBy VERSION_DESC = new KalturaMetadataOrderBy("-version");
		public static readonly KalturaMetadataOrderBy CREATED_AT_ASC = new KalturaMetadataOrderBy("+createdAt");
		public static readonly KalturaMetadataOrderBy CREATED_AT_DESC = new KalturaMetadataOrderBy("-createdAt");
		public static readonly KalturaMetadataOrderBy UPDATED_AT_ASC = new KalturaMetadataOrderBy("+updatedAt");
		public static readonly KalturaMetadataOrderBy UPDATED_AT_DESC = new KalturaMetadataOrderBy("-updatedAt");

		private KalturaMetadataOrderBy(string name) : base(name) { }
	}
}
