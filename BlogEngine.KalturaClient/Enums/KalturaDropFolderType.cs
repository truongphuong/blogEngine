namespace Kaltura
{
	public sealed class KalturaDropFolderType : KalturaStringEnum
	{
		public static readonly KalturaDropFolderType LOCAL = new KalturaDropFolderType("1");
		public static readonly KalturaDropFolderType FTP = new KalturaDropFolderType("2");
		public static readonly KalturaDropFolderType SCP = new KalturaDropFolderType("3");
		public static readonly KalturaDropFolderType SFTP = new KalturaDropFolderType("4");

		private KalturaDropFolderType(string name) : base(name) { }
	}
}
