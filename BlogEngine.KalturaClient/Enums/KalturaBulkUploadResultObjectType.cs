namespace Kaltura
{
	public sealed class KalturaBulkUploadResultObjectType : KalturaStringEnum
	{
		public static readonly KalturaBulkUploadResultObjectType ENTRY = new KalturaBulkUploadResultObjectType("1");

		private KalturaBulkUploadResultObjectType(string name) : base(name) { }
	}
}
