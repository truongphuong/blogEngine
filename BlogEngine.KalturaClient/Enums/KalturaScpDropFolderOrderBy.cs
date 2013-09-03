namespace Kaltura
{
	public sealed class KalturaScpDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaScpDropFolderOrderBy ID_ASC = new KalturaScpDropFolderOrderBy("+id");
		public static readonly KalturaScpDropFolderOrderBy ID_DESC = new KalturaScpDropFolderOrderBy("-id");
		public static readonly KalturaScpDropFolderOrderBy NAME_ASC = new KalturaScpDropFolderOrderBy("+name");
		public static readonly KalturaScpDropFolderOrderBy NAME_DESC = new KalturaScpDropFolderOrderBy("-name");
		public static readonly KalturaScpDropFolderOrderBy CREATED_AT_ASC = new KalturaScpDropFolderOrderBy("+createdAt");
		public static readonly KalturaScpDropFolderOrderBy CREATED_AT_DESC = new KalturaScpDropFolderOrderBy("-createdAt");
		public static readonly KalturaScpDropFolderOrderBy UPDATED_AT_ASC = new KalturaScpDropFolderOrderBy("+updatedAt");
		public static readonly KalturaScpDropFolderOrderBy UPDATED_AT_DESC = new KalturaScpDropFolderOrderBy("-updatedAt");

		private KalturaScpDropFolderOrderBy(string name) : base(name) { }
	}
}
