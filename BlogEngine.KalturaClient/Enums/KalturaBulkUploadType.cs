namespace Kaltura
{
	public sealed class KalturaBulkUploadType : KalturaStringEnum
	{
		public static readonly KalturaBulkUploadType CSV = new KalturaBulkUploadType("bulkUploadCsv.CSV");
		public static readonly KalturaBulkUploadType XML = new KalturaBulkUploadType("bulkUploadXml.XML");
		public static readonly KalturaBulkUploadType DROP_FOLDER_XML = new KalturaBulkUploadType("dropFolderXmlBulkUpload.DROP_FOLDER_XML");

		private KalturaBulkUploadType(string name) : base(name) { }
	}
}
