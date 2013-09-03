namespace Kaltura
{
	public sealed class KalturaFtpDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFtpDropFolderOrderBy ID_ASC = new KalturaFtpDropFolderOrderBy("+id");
		public static readonly KalturaFtpDropFolderOrderBy ID_DESC = new KalturaFtpDropFolderOrderBy("-id");
		public static readonly KalturaFtpDropFolderOrderBy NAME_ASC = new KalturaFtpDropFolderOrderBy("+name");
		public static readonly KalturaFtpDropFolderOrderBy NAME_DESC = new KalturaFtpDropFolderOrderBy("-name");
		public static readonly KalturaFtpDropFolderOrderBy CREATED_AT_ASC = new KalturaFtpDropFolderOrderBy("+createdAt");
		public static readonly KalturaFtpDropFolderOrderBy CREATED_AT_DESC = new KalturaFtpDropFolderOrderBy("-createdAt");
		public static readonly KalturaFtpDropFolderOrderBy UPDATED_AT_ASC = new KalturaFtpDropFolderOrderBy("+updatedAt");
		public static readonly KalturaFtpDropFolderOrderBy UPDATED_AT_DESC = new KalturaFtpDropFolderOrderBy("-updatedAt");

		private KalturaFtpDropFolderOrderBy(string name) : base(name) { }
	}
}
