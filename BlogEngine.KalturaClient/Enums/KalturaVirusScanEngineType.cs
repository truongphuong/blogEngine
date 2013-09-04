namespace Kaltura
{
	public sealed class KalturaVirusScanEngineType : KalturaStringEnum
	{
		public static readonly KalturaVirusScanEngineType SYMANTEC_SCAN_ENGINE = new KalturaVirusScanEngineType("symantecScanEngine.SymantecScanEngine");
		public static readonly KalturaVirusScanEngineType SYMANTEC_SCAN_JAVA_ENGINE = new KalturaVirusScanEngineType("symantecScanEngine.SymantecScanJavaEngine");

		private KalturaVirusScanEngineType(string name) : base(name) { }
	}
}
