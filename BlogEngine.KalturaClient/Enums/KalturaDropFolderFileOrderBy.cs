namespace Kaltura
{
	public sealed class KalturaDropFolderFileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDropFolderFileOrderBy ID_ASC = new KalturaDropFolderFileOrderBy("+id");
		public static readonly KalturaDropFolderFileOrderBy ID_DESC = new KalturaDropFolderFileOrderBy("-id");
		public static readonly KalturaDropFolderFileOrderBy FILE_NAME_ASC = new KalturaDropFolderFileOrderBy("+fileName");
		public static readonly KalturaDropFolderFileOrderBy FILE_NAME_DESC = new KalturaDropFolderFileOrderBy("-fileName");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_ASC = new KalturaDropFolderFileOrderBy("+fileSize");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_DESC = new KalturaDropFolderFileOrderBy("-fileSize");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new KalturaDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new KalturaDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly KalturaDropFolderFileOrderBy PARSED_SLUG_ASC = new KalturaDropFolderFileOrderBy("+parsedSlug");
		public static readonly KalturaDropFolderFileOrderBy PARSED_SLUG_DESC = new KalturaDropFolderFileOrderBy("-parsedSlug");
		public static readonly KalturaDropFolderFileOrderBy PARSED_FLAVOR_ASC = new KalturaDropFolderFileOrderBy("+parsedFlavor");
		public static readonly KalturaDropFolderFileOrderBy PARSED_FLAVOR_DESC = new KalturaDropFolderFileOrderBy("-parsedFlavor");
		public static readonly KalturaDropFolderFileOrderBy CREATED_AT_ASC = new KalturaDropFolderFileOrderBy("+createdAt");
		public static readonly KalturaDropFolderFileOrderBy CREATED_AT_DESC = new KalturaDropFolderFileOrderBy("-createdAt");
		public static readonly KalturaDropFolderFileOrderBy UPDATED_AT_ASC = new KalturaDropFolderFileOrderBy("+updatedAt");
		public static readonly KalturaDropFolderFileOrderBy UPDATED_AT_DESC = new KalturaDropFolderFileOrderBy("-updatedAt");

		private KalturaDropFolderFileOrderBy(string name) : base(name) { }
	}
}
