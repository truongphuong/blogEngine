namespace Kaltura
{
	public sealed class KalturaSshDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaSshDropFolderOrderBy ID_ASC = new KalturaSshDropFolderOrderBy("+id");
		public static readonly KalturaSshDropFolderOrderBy ID_DESC = new KalturaSshDropFolderOrderBy("-id");
		public static readonly KalturaSshDropFolderOrderBy NAME_ASC = new KalturaSshDropFolderOrderBy("+name");
		public static readonly KalturaSshDropFolderOrderBy NAME_DESC = new KalturaSshDropFolderOrderBy("-name");
		public static readonly KalturaSshDropFolderOrderBy CREATED_AT_ASC = new KalturaSshDropFolderOrderBy("+createdAt");
		public static readonly KalturaSshDropFolderOrderBy CREATED_AT_DESC = new KalturaSshDropFolderOrderBy("-createdAt");
		public static readonly KalturaSshDropFolderOrderBy UPDATED_AT_ASC = new KalturaSshDropFolderOrderBy("+updatedAt");
		public static readonly KalturaSshDropFolderOrderBy UPDATED_AT_DESC = new KalturaSshDropFolderOrderBy("-updatedAt");

		private KalturaSshDropFolderOrderBy(string name) : base(name) { }
	}
}
