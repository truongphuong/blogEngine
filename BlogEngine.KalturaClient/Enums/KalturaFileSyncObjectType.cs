namespace Kaltura
{
	public sealed class KalturaFileSyncObjectType : KalturaStringEnum
	{
		public static readonly KalturaFileSyncObjectType ENTRY = new KalturaFileSyncObjectType("1");
		public static readonly KalturaFileSyncObjectType UICONF = new KalturaFileSyncObjectType("2");
		public static readonly KalturaFileSyncObjectType BATCHJOB = new KalturaFileSyncObjectType("3");
		public static readonly KalturaFileSyncObjectType ASSET = new KalturaFileSyncObjectType("4");
		public static readonly KalturaFileSyncObjectType METADATA = new KalturaFileSyncObjectType("5");
		public static readonly KalturaFileSyncObjectType METADATA_PROFILE = new KalturaFileSyncObjectType("6");
		public static readonly KalturaFileSyncObjectType SYNDICATION_FEED = new KalturaFileSyncObjectType("7");
		public static readonly KalturaFileSyncObjectType CONVERSION_PROFILE = new KalturaFileSyncObjectType("8");
		public static readonly KalturaFileSyncObjectType FLAVOR_ASSET = new KalturaFileSyncObjectType("4");
		public static readonly KalturaFileSyncObjectType GENERIC_DISTRIBUTION_ACTION = new KalturaFileSyncObjectType("contentDistribution.GenericDistributionAction");
		public static readonly KalturaFileSyncObjectType ENTRY_DISTRIBUTION = new KalturaFileSyncObjectType("contentDistribution.EntryDistribution");
		public static readonly KalturaFileSyncObjectType DISTRIBUTION_PROFILE = new KalturaFileSyncObjectType("contentDistribution.DistributionProfile");

		private KalturaFileSyncObjectType(string name) : base(name) { }
	}
}
