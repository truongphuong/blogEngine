namespace Kaltura
{
	public sealed class KalturaSchemaType : KalturaStringEnum
	{
		public static readonly KalturaSchemaType SYNDICATION = new KalturaSchemaType("syndication");
		public static readonly KalturaSchemaType BULK_UPLOAD_XML = new KalturaSchemaType("bulkUploadXml.bulkUploadXML");
		public static readonly KalturaSchemaType BULK_UPLOAD_RESULT_XML = new KalturaSchemaType("bulkUploadXml.bulkUploadResultXML");
		public static readonly KalturaSchemaType DROP_FOLDER_XML = new KalturaSchemaType("dropFolderXmlBulkUpload.dropFolderXml");
		public static readonly KalturaSchemaType SERVE_API = new KalturaSchemaType("cuePoint.serveAPI");
		public static readonly KalturaSchemaType INGEST_API = new KalturaSchemaType("cuePoint.ingestAPI");

		private KalturaSchemaType(string name) : base(name) { }
	}
}
