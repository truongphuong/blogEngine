namespace Kaltura
{
	public sealed class KalturaDropFolderFileErrorCode : KalturaStringEnum
	{
		public static readonly KalturaDropFolderFileErrorCode ERROR_UPDATE_ENTRY = new KalturaDropFolderFileErrorCode("1");
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADD_ENTRY = new KalturaDropFolderFileErrorCode("2");
		public static readonly KalturaDropFolderFileErrorCode FLAVOR_NOT_FOUND = new KalturaDropFolderFileErrorCode("3");
		public static readonly KalturaDropFolderFileErrorCode FLAVOR_MISSING_IN_FILE_NAME = new KalturaDropFolderFileErrorCode("4");
		public static readonly KalturaDropFolderFileErrorCode SLUG_REGEX_NO_MATCH = new KalturaDropFolderFileErrorCode("5");
		public static readonly KalturaDropFolderFileErrorCode ERROR_READING_FILE = new KalturaDropFolderFileErrorCode("6");
		public static readonly KalturaDropFolderFileErrorCode ERROR_DOWNLOADING_FILE = new KalturaDropFolderFileErrorCode("7");
		public static readonly KalturaDropFolderFileErrorCode LOCAL_FILE_WRONG_SIZE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_SIZE");
		public static readonly KalturaDropFolderFileErrorCode LOCAL_FILE_WRONG_CHECKSUM = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_CHECKSUM");
		public static readonly KalturaDropFolderFileErrorCode ERROR_WRITING_TEMP_FILE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_WRITING_TEMP_FILE");
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADDING_BULK_UPLOAD = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_ADDING_BULK_UPLOAD");

		private KalturaDropFolderFileErrorCode(string name) : base(name) { }
	}
}
