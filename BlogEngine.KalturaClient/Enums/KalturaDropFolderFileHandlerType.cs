namespace Kaltura
{
	public sealed class KalturaDropFolderFileHandlerType : KalturaStringEnum
	{
		public static readonly KalturaDropFolderFileHandlerType CONTENT = new KalturaDropFolderFileHandlerType("1");
		public static readonly KalturaDropFolderFileHandlerType XML = new KalturaDropFolderFileHandlerType("dropFolderXmlBulkUpload.XML");

		private KalturaDropFolderFileHandlerType(string name) : base(name) { }
	}
}
