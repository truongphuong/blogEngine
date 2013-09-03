namespace Kaltura
{
	public sealed class KalturaSftpDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaSftpDropFolderOrderBy ID_ASC = new KalturaSftpDropFolderOrderBy("+id");
		public static readonly KalturaSftpDropFolderOrderBy ID_DESC = new KalturaSftpDropFolderOrderBy("-id");
		public static readonly KalturaSftpDropFolderOrderBy NAME_ASC = new KalturaSftpDropFolderOrderBy("+name");
		public static readonly KalturaSftpDropFolderOrderBy NAME_DESC = new KalturaSftpDropFolderOrderBy("-name");
		public static readonly KalturaSftpDropFolderOrderBy CREATED_AT_ASC = new KalturaSftpDropFolderOrderBy("+createdAt");
		public static readonly KalturaSftpDropFolderOrderBy CREATED_AT_DESC = new KalturaSftpDropFolderOrderBy("-createdAt");
		public static readonly KalturaSftpDropFolderOrderBy UPDATED_AT_ASC = new KalturaSftpDropFolderOrderBy("+updatedAt");
		public static readonly KalturaSftpDropFolderOrderBy UPDATED_AT_DESC = new KalturaSftpDropFolderOrderBy("-updatedAt");

		private KalturaSftpDropFolderOrderBy(string name) : base(name) { }
	}
}
