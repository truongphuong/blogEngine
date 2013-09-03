namespace Kaltura
{
	public sealed class KalturaRemoteDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaRemoteDropFolderOrderBy ID_ASC = new KalturaRemoteDropFolderOrderBy("+id");
		public static readonly KalturaRemoteDropFolderOrderBy ID_DESC = new KalturaRemoteDropFolderOrderBy("-id");
		public static readonly KalturaRemoteDropFolderOrderBy NAME_ASC = new KalturaRemoteDropFolderOrderBy("+name");
		public static readonly KalturaRemoteDropFolderOrderBy NAME_DESC = new KalturaRemoteDropFolderOrderBy("-name");
		public static readonly KalturaRemoteDropFolderOrderBy CREATED_AT_ASC = new KalturaRemoteDropFolderOrderBy("+createdAt");
		public static readonly KalturaRemoteDropFolderOrderBy CREATED_AT_DESC = new KalturaRemoteDropFolderOrderBy("-createdAt");
		public static readonly KalturaRemoteDropFolderOrderBy UPDATED_AT_ASC = new KalturaRemoteDropFolderOrderBy("+updatedAt");
		public static readonly KalturaRemoteDropFolderOrderBy UPDATED_AT_DESC = new KalturaRemoteDropFolderOrderBy("-updatedAt");

		private KalturaRemoteDropFolderOrderBy(string name) : base(name) { }
	}
}
