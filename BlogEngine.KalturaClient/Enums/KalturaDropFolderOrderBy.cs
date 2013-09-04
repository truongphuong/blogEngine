namespace Kaltura
{
	public sealed class KalturaDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDropFolderOrderBy ID_ASC = new KalturaDropFolderOrderBy("+id");
		public static readonly KalturaDropFolderOrderBy ID_DESC = new KalturaDropFolderOrderBy("-id");
		public static readonly KalturaDropFolderOrderBy NAME_ASC = new KalturaDropFolderOrderBy("+name");
		public static readonly KalturaDropFolderOrderBy NAME_DESC = new KalturaDropFolderOrderBy("-name");
		public static readonly KalturaDropFolderOrderBy CREATED_AT_ASC = new KalturaDropFolderOrderBy("+createdAt");
		public static readonly KalturaDropFolderOrderBy CREATED_AT_DESC = new KalturaDropFolderOrderBy("-createdAt");
		public static readonly KalturaDropFolderOrderBy UPDATED_AT_ASC = new KalturaDropFolderOrderBy("+updatedAt");
		public static readonly KalturaDropFolderOrderBy UPDATED_AT_DESC = new KalturaDropFolderOrderBy("-updatedAt");

		private KalturaDropFolderOrderBy(string name) : base(name) { }
	}
}
