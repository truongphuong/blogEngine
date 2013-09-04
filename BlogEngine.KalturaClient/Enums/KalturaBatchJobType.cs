namespace Kaltura
{
	public sealed class KalturaBatchJobType : KalturaStringEnum
	{
		public static readonly KalturaBatchJobType CONVERT = new KalturaBatchJobType("0");
		public static readonly KalturaBatchJobType IMPORT = new KalturaBatchJobType("1");
		public static readonly KalturaBatchJobType DELETE = new KalturaBatchJobType("2");
		public static readonly KalturaBatchJobType FLATTEN = new KalturaBatchJobType("3");
		public static readonly KalturaBatchJobType BULKUPLOAD = new KalturaBatchJobType("4");
		public static readonly KalturaBatchJobType DVDCREATOR = new KalturaBatchJobType("5");
		public static readonly KalturaBatchJobType DOWNLOAD = new KalturaBatchJobType("6");
		public static readonly KalturaBatchJobType OOCONVERT = new KalturaBatchJobType("7");
		public static readonly KalturaBatchJobType CONVERT_PROFILE = new KalturaBatchJobType("10");
		public static readonly KalturaBatchJobType POSTCONVERT = new KalturaBatchJobType("11");
		public static readonly KalturaBatchJobType PULL = new KalturaBatchJobType("12");
		public static readonly KalturaBatchJobType REMOTE_CONVERT = new KalturaBatchJobType("13");
		public static readonly KalturaBatchJobType EXTRACT_MEDIA = new KalturaBatchJobType("14");
		public static readonly KalturaBatchJobType MAIL = new KalturaBatchJobType("15");
		public static readonly KalturaBatchJobType NOTIFICATION = new KalturaBatchJobType("16");
		public static readonly KalturaBatchJobType CLEANUP = new KalturaBatchJobType("17");
		public static readonly KalturaBatchJobType SCHEDULER_HELPER = new KalturaBatchJobType("18");
		public static readonly KalturaBatchJobType BULKDOWNLOAD = new KalturaBatchJobType("19");
		public static readonly KalturaBatchJobType DB_CLEANUP = new KalturaBatchJobType("20");
		public static readonly KalturaBatchJobType PROVISION_PROVIDE = new KalturaBatchJobType("21");
		public static readonly KalturaBatchJobType CONVERT_COLLECTION = new KalturaBatchJobType("22");
		public static readonly KalturaBatchJobType STORAGE_EXPORT = new KalturaBatchJobType("23");
		public static readonly KalturaBatchJobType PROVISION_DELETE = new KalturaBatchJobType("24");
		public static readonly KalturaBatchJobType STORAGE_DELETE = new KalturaBatchJobType("25");
		public static readonly KalturaBatchJobType EMAIL_INGESTION = new KalturaBatchJobType("26");
		public static readonly KalturaBatchJobType METADATA_IMPORT = new KalturaBatchJobType("27");
		public static readonly KalturaBatchJobType METADATA_TRANSFORM = new KalturaBatchJobType("28");
		public static readonly KalturaBatchJobType FILESYNC_IMPORT = new KalturaBatchJobType("29");
		public static readonly KalturaBatchJobType CAPTURE_THUMB = new KalturaBatchJobType("30");
		public static readonly KalturaBatchJobType VIRUS_SCAN = new KalturaBatchJobType("virusScan.VirusScan");
		public static readonly KalturaBatchJobType DISTRIBUTION_SUBMIT = new KalturaBatchJobType("contentDistribution.DistributionSubmit");
		public static readonly KalturaBatchJobType DISTRIBUTION_UPDATE = new KalturaBatchJobType("contentDistribution.DistributionUpdate");
		public static readonly KalturaBatchJobType DISTRIBUTION_DELETE = new KalturaBatchJobType("contentDistribution.DistributionDelete");
		public static readonly KalturaBatchJobType DISTRIBUTION_FETCH_REPORT = new KalturaBatchJobType("contentDistribution.DistributionFetchReport");
		public static readonly KalturaBatchJobType DISTRIBUTION_ENABLE = new KalturaBatchJobType("contentDistribution.DistributionEnable");
		public static readonly KalturaBatchJobType DISTRIBUTION_DISABLE = new KalturaBatchJobType("contentDistribution.DistributionDisable");
		public static readonly KalturaBatchJobType DISTRIBUTION_SYNC = new KalturaBatchJobType("contentDistribution.DistributionSync");
		public static readonly KalturaBatchJobType DROP_FOLDER_WATCHER = new KalturaBatchJobType("dropFolder.DropFolderWatcher");
		public static readonly KalturaBatchJobType DROP_FOLDER_HANDLER = new KalturaBatchJobType("dropFolder.DropFolderHandler");
		public static readonly KalturaBatchJobType PARSE_CAPTION_ASSET = new KalturaBatchJobType("captionSearch.parseCaptionAsset");

		private KalturaBatchJobType(string name) : base(name) { }
	}
}
